import React from 'react';
import './ass.css';

import logobranca from './Logobranca.png';
import Login from './Login.png';
import Home from './Home.png';
import carrinho from './carrinho.png';
import logo from './logo.jpg';
import ReactPlayer from 'react-player'
import VideoPlayer from 'react-video-js-player';
import video from './tate.mp4';
import dragon from './dragon.jpg';
import superonze from './super onze.png';
import overlord from './overlord.jpg';



export default function Assistir() {
  return(


    <div className='master'>

      <div className='principal'>
      <div className='logo'> <img src={logobranca} height='100px' /></div>
          <div className='inicio'><input type='search' name='busca' placeholder='O  que você procura?'></input></div>
          <div className='home'><a href='../Principal/index.js'><img src={Home} height='20px'/></a></div>
          <div className='carrinho'><a href='#'><img src={carrinho}  height='20px'/></a><p>carrinho</p></div>
          <div className='entre'><a href='#'><img src={Login}  height='20px'/></a><p>Entre</p></div>

      </div>
      <div className='logozin'>
        <div className='logo'><img src={logo} width='300px'/></div>
      </div>

      <div className='juju'>
        <h1>jujutsu kaisen</h1>
      </div>

      <div className='carrosel5'>

        <div className='videos'>
         <VideoPlayer src={video}  width="720" height='420'/>
        </div>
      </div>

      <div className='comentario'><h5>
        Títulos alternativos: jujutsu kaisen
            Nº de episódios: 01
      <br></br>
            Status: Completo
              Formato: MP4
          Tamanho médio: 1,2 GB
               Uploader: 
                Jujutsu
       <br></br>
           Lançado em: 2020
            Estúdio: Panini

          Resolução: 1920x1080
               <br></br>
             Censura: Não
         Gêneros: : Ficção de aventura, Fantasia sombria, Ficção supernatural
               <br></br>
         Áudio/Legenda: Japonês / Português BR
               <br></br>
          Apesar do estudante colegial Yuuji Itadori ter grande força física, ele se inscreve no Clube de Ocultismo.
          <br></br> Certo dia, eles encontram um “objeto amaldiçoado” e retiram o selo,
           atraindo criaturas chamadas de “maldições”.
</h5></div>

      <div className='assistir'>
      <div className='caixas2'>
          <img  className='imagem2' src={dragon} height='145px'/>
            <p>Dragon ball</p>
            <button className='button2'>assistir</button>
          </div>

          <div className='caixas3'>
          <img  className='imagem3' src={overlord} height='150px'/>
            <p>overlord</p>
            <button className='button2'>assistir</button>
          </div>

          <div className='caixas4'>
          <img  className='imagem4' src={superonze} height='150px'/>
            <p>Super Onze</p>
            <button className='button2'>assistir</button>
          </div>

          
      </div>


      <div className='cabeca1'>
          <img className='logoo' src={logo}  height='50px'/>
          <div className='atendimento'>Atendimento
            <p> Telefone:  957210878</p>
          </div>
          <div className='Pagamento'>Pagamento

              <p>Paypal</p>

              <p>Boleto</p>
              <p>Pagseguro</p>
           </div>
           <div className='nossas'>Nossas redes
               <p>Facebook</p>
              <p>Twiter</p>
              <p>Youtube</p>
              <p>Discord</p>

              </div>
              </div>





    </div>




)

}

