import React from 'react';
import logo from './logo.jpg';
import './login.css';
import Img from 'react-image';


export default function Cadastrar() {
    return (
        <div className='container'>
           
             <img src={logo} className="imagem"  width='300px'  alt="logo"/>
             <div className='primeira-coluna'>
                 <h2 className='titulo'> Criar conta</h2>
                 <div className='form'>

                     <input type='text' className='texto' size='40' placeholder='CPF'></input>
                     <br></br>
                     <input type='text' class="texto" size="40" placeholder='Telefone'></input>
                     <br></br>
                     <input type='text' class="texto" size="40" placeholder='Senha'></input>
                     <br></br>

                     <button class="button" id="Login"><a href="#"><h5>Criar conta</h5></a></button>

                     <ul>
                         <li className='crie'><a href='../Login/index.js'><h7>Já tem sua conta</h7></a></li>
                     </ul>
                 </div>
            </div>

           
       </div>
    )
}