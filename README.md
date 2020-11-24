# AnimeHub 

#### Introdução 


Nosso site é um streaming focado 100% em anime. Com animes para crianças, adolescentes e adultos. 
Nosso projeto consiste também numa página de mangas traduzidos em que o usuário poderá aproveitar o conteúdo extra dos animes.



## Casos de Uso
![](https://i.imgur.com/VA8XEiM.png)




### Usuário
O Usuário pode acessar o site, criar cadastros e fazer login (Diferente do Gerente ele precisa fazer cadastro). Podendo consultar os animes e assisti-los. O usuário pode também comprar os Mangás da nossa loja AnimeHub. Assim podendo pagar com todas as formas disponíveis do site, sejam elas: Paypal, Pagseguro, Boleto, Cartão.


## Mer
![](https://i.imgur.com/gV9Aoc4.png)

##Scrip do Bando de Dados
###create database sitebd;

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


## Prototipação 

#### Primeira tela 
Primeira tela
Na tela principal, todas as pessoas que clicam no link do site é direcionada à esta tela onde se encontra a logo do nosso site, o Botão de fazer login, um botão de compra e um rodapé.
![](https://i.imgur.com/pGTlTVp.png)
****

#### Tela de Login
Onde o usuário poderá fazer login e entrar no site. Ele precisa das credenciais do cadastro. Nele contém o criar conta se o usuário não tiver uma conta criada. E contendo esqueceu a senha, onde o cliente pode redefinir sua senha caso tenha esquecido. 

![](https://i.imgur.com/vBNeS9b.png)
****

#### Criar conta 
Nessa parte o cliente pode fazer sua conta. Para fazer sua conta precisamos de 4 credenciais:
CPF – Campo onde só será aceito o CPF. 
Telefone – Campo onde só será aceito o telefone. 
E-MAIL – Campo onde o usuário definira o E-mail há ser utilizado para se cadastrar. 
SENHA – Onde o usuário escolherá sua senha, para criar sua conta. Depois de todos os tópicos apresentados, o cliente poderá acessar o site.

![](https://i.imgur.com/KwxM18p.png)
****

#### Acessar 
A seguir, nosso player de vídeo onde o usuário pode escolher o nível do volume e a velocidade do vídeo.
Contém um carrossel, onde o usuário terá acesso os melhores animes no momento. E temos 6 “cards”, onde ficam os animes disponíveis para assistir. Clicando em cada um deles, você é direcionado a página do anime escolhido pelo usuário.
![](https://i.imgur.com/XmZxH3H.png)
****
#### Assistir
Quando o usuário escolher o anime que deseja assistir, ele é direcionado para esta tela. Onde podemos assistir o anime escolhido, contendo as informações do anime na descrição. A seguir, nosso player de vídeo onde o usuário pode escolher o nível do volume e a velocidade do vídeo.
Clicando na parte superior, com um ícone de carrinho podemos ser direcionados a parte de comprar de Mangás.

![](https://i.imgur.com/wxzrINX.png)
****
#### Comprar
Na tela de compras, podemos acessar os Mangás para a compra. Onde se encontra diversos Mangás, com diversos preços. Temos os Mangás mais novos e lançamentos e temos os mais antigos e mais famosos. Todos eles são adquiridos virtualmente, ou seja, podemos comprar dentro do próprio site.

![](https://i.imgur.com/OdTNFSU.png)
****

#### Produto
Quando escolhermos o Mangá que queremos adquirir, somos direcionados à esta tela. Onde se encontra o processo do produto, a quantidade do produto. E temos o botão comprar onde somos direcionados a outra pagina, que seria a tela de pagamento.
![](https://i.imgur.com/YcIl5kh.png)
***

#### Finalizar pedido
Para finalizar o pedido, podemos escolher diversas formas de fazer o pagamento. Seja boleto ou em cartão até mesmo em Paypal e não esquecendo a PagSeguro.
![](https://i.imgur.com/tYlEWsR.png)
Finalizar pedido



## Integrantes da StacksTech

#### Lucas Francisco N°23
#### Djalma Prado    N°09
#### Pedro Staaks    N°34
#### Davi luiz       N°08
#### Nicolas Torres  N°32
#### Guilherme       N°16
*******

## Links 
https://trello.com/b/FCPmcP93/tcc
