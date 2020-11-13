
import React from 'react';
import Img from 'react-image';
import logopreta from './Logo preta.jpg'
import capa from './CAPA.png';
import Dragon from './Dragon.jpg'
import logobranca from './Logobranca.png';
import monster from './monster.jpg';
import never from './never.jpg';
import overlord from './Overlord.jpg';
import pikachu from './pikachu.jpg';
import Vinland from './vinland.jpg';

import './login1.css';




export default function Princial() {
    return (

        <div className='master'>
            <div className='index'>
                <img className='logo' src={logobranca} width='100px'/>
                <button className='login1 '><a href='../Login/index.js'><h5>Login</h5></a></button>
                <button className='Entrar'><a href='../Acessar/index.js'><h5>Entrar</h5></a></button>
            </div>

            <div className='comprar'>
                <div class='text'>
                  <h3>Seu momento com tudo que você sempre quis</h3>
                  <p3>mangás em Pdf e garanta diversos</p3>
                  <br/>
                  <p2> beneficios para curtir seus desenhos e</p2>
                  <br/>
                  <p1>animes preferidos. Confira</p1>
                </div>
               <button className='button'>comprar</button>
                <div class='cards'></div>
                <div class='cards2'></div>
                 
                <div class='cards3'></div>
            </div>

            <div className='cabeca'>
                <div className='logo'><img  src={logopreta} height='50px'/></div>


                <div class="atendimento">Atendimento
                   <p>Telefone:  957210878</p>
                 </div>

                 <div class="Pagamento">Pagamento
                
                <p>Paypal</p>
                
                <p>Boleto</p>
                <p>Pagseguro</p>
              </div>

              <div class="nossas">Nossas redes
                <p>Facebook</p>
                <p>Twiter</p>
                <p>Youtube</p>
                <p>Discord</p>

              </div>



            
                                
            </div>

        </div>

    
    )
}