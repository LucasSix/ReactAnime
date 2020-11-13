import React from 'react';
import Img from 'react-image';
import logo from './logo.jpg';
import './login.css';

export default function Login() {
    return (
       <div className='container'>
           
             <img src={logo} className="imagem"  width='300px'  alt="logo"/>
             <div className='primeira-coluna'>
                 <h2 className='titulo'> Esqueci a senha </h2>
                 <div className='form'>
                     <input type='text' className='texto' size='40' placeholder='E-mail ou Nome de Usuario'></input>
                     <br></br>
                     
                     <br></br>
                     <button class="button" id="Login"><a href="#"><h5>Mandar E-mail</h5></a></button>

                     <ul>
                         <li className='crie'><a href='../Cadastrar/index.js'><h7>Cadastrar</h7></a></li>
                     </ul>
                 </div>
            </div>

           
       </div>
    )
}
