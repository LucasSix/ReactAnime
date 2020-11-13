import React from 'react';
import {Switch, BrowserRouter, Route} from 'react-router-dom';

import aApp from './pages/App'
import Acessar from './pages/Acessar'
import Cadastrar from './pages/Cadastrar'
import Login from './pages/Login'
import Principal from './pages/Principal'
import Senha from './pages/Senha'


export default function Routes(){



    return(
       <BrowserRouter>
          <switch>
              <Route path="/" exact={true} component={Principal}/>
              <Route path="/Acessar"       component={Acessar}/>
              <Route path="/Cadastrar"      component={Cadastrar}/>
              <Route path="/Login"          component={Login}/>
               <Route path="/Principal"      component={Principal}/>
               <Route path="/Senha"      component={Senha}/>
          </switch>
       </BrowserRouter>
    )
}