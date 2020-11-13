import React from 'react';
import logo from './logo.jpg';
import Beyblade from './gt.jpg';
import dragon from './dragon.jpg';
import carrinho from './carrinho.png';
import Home from './Home.png';
import Login from './Login.png';
import logobranca from './Logobranca.png';
import nogame from './nogame.jpg';
import overlord from './overlord.jpg';
import rezero from './Rezero.png';
import slime from './slime.jpg';
import superonze from './super onze.png';
import hunter from './hunter.jpg';

import './Acessar.css';


export default function Acessar() {
    return (

      <div className='master'>
        <div className='principal'>

          <div className='logo'> <img src={logobranca} height='100px' /></div>
          <div className='inicio'><input type='search' name='busca' placeholder='O  que você procura?'></input></div>
          <div className='home'><a href='../Principal/index.js'><img src={Home} height='20px'/></a></div>
          <div className='carrinho'><a href='#'><img src={carrinho}  height='20px'/></a><p>carrinho</p></div>
          <div className='entre'><a href='#'><img src={Login}  height='20px'/></a><p>Entre</p></div>
        </div>

        <div className='carrosel'>
          <div className='box'>
          <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
              <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
              <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
              <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
              <div class="carousel-item active">
                <img src={hunter} class="d-block w-100" alt="..."/>
              </div>
              
              <div class="carousel-item">
                <img src={slime}  class="d-block w-100" alt="..."/>
              </div>
              <div class="carousel-item">
                <img src={nogame} class="d-block w-100" alt="..."/>
              </div>


            </div>
            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
              <span class="carousel-control-prev-icon" aria-hidden="true"></span>
              <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
              <span class="carousel-control-next-icon" aria-hidden="true"></span>
              <span class="sr-only">Next</span>
            </a>
          </div>

          </div>


        </div>
        <div className='assistir'>
          

          <div className='caixas2'>
          <img  className='imagem2' src={dragon} height='145px'/>
            <p>Dragon ball</p>
            <button className='button2'>assistir</button>
          </div>

          <div className='caixas3'>
          <img  className='imagem3' src={overlord} height='160px'/>
            <p>overlord</p>
            <button className='button2'>assistir</button>
          </div>

          <div className='caixas4'>
          <img  className='imagem4' src={superonze} height='150px'/>
            <p>Super Onze</p>
            <button className='button2'>assistir</button>
          </div>

          



        </div>
        <div className='assistir'>
          

          <div className='caixas2'>
          <img  className='imagem2' src={rezero} height='145px'/>
            <p>Re zero</p>
            <button className='button2'>assistir</button>
          </div>

          <div className='caixas3'>
          <img  className='imagem3' src={Beyblade} height='150px'/>
            <p>Beybalde GT</p>
            <button className='button2'>Assitir </button>
          </div>

          <div className='caixas4'>
          <img  className='imagem4' src={nogame} height='150px'/>
            <p>Dragon ball</p>
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