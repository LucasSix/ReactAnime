create database sitebd;

use sitebd;

show tables;

create table tb_anime (
id_anime int primary key auto_increment,
nm_anime varchar(100),
vl_duracao decimal(15,5),
nr_classificacao_idade int,
dt_lancamento date,
vl_avaliacao decimal(15,5),
nm_autor varchar(100),
ds_genero varchar(100),
img_capa varchar(100)
);

create table tb_permissao (

id_permissao int primary key auto_increment,
id_funcionario int,
id_anime int,
id_manga int,
bt_alterar_anime bool,
bt_add_anime bool,
bt_alterar_manga bool,
bt_visualizar bool,
Foreign key (id_funcionario) references tb_funcionario (id_funcionario),
Foreign key (id_anime) references tb_anime (id_anime),
Foreign key (id_manga) references tb_manga (id_manga)
);

create table tb_manga (
id_manga  int primary key auto_increment,
nm_manga varchar(100),
vl_preco decimal(15,5),
dt_lancamento date,
nm_autor varchar(100),
ds_genero varchar(100),
nr_classificacao_idade int,
vl_avaliacao decimal(15,5),
qt_pagina int,
bt_disponivel bool,
img_capa varchar(100)
);

create table tb_funcionario(
id_funcionario  int primary key auto_increment,
nm_funcionario varchar(100),
dt_nascimento date,
nr_rg int,
nr_cpf int,
nr_telefone int,
ds_endereco varchar(100),
ds_email varchar(100),
dt_ultimo_acesso date
);

create table tb_cliente (

id_cliente  int primary key auto_increment,
id_login int,
nm_cliente varchar(100),
nr_cpf int,
nr_telefone int,
dt_ultimo_acesso date,
dt_nascimento date,
Foreign key (id_login) references tb_login (id_login)
);

create table tb_login (
id_login int primary key auto_increment,
ds_email varchar(100),
ds_senha varchar(100)
);

create table tb_compra (

id_compra int primary key auto_increment,
id_cliente int,
bt_pago bool,
bt_cartao bool,
bt_pay_pal bool,
bt_pague_seguro bool,
dt_dia_compra date,
Foreign key (id_cliente) references tb_cliente (id_cliente)
);

create table tb_compra_manga (

id_compra_manga int primary key auto_increment,
id_compra int,
id_manga int,
vl_total decimal(15,5),
qt_manga int,
Foreign key (id_compra) references tb_compra (id_compra),
Foreign key (id_manga) references tb_manga (id_manga)
);

create table tb_manga (
id_manga int primary key auto_increment,
nm_manga varchar(100),
vl_preco decimal(15,5),
nm_autor varchar(100),
ds_genero  varchar(100),
nr_classificacao_idade int,
vl_avaliacao decimal(15,5),
qt_pagina int,
bt_disponivel bool,
img_capa_manga varchar(100)
);

