import React from 'react';
import ReactDOM from 'react-dom';
import {
    Route,
    BrowserRouter,
    Routes,
    Navigate
} from 'react-router-dom';

import './index.css';

import Login from '../src/Pages/Login/Login.jsx';
import NotFound from './Pages/NotFound/NotFound'
import ListarEquipamentos from './Pages/ListarEquipamentos/ListarEquipamentos';
import Empresas from './Pages/Empresas/Empresas.jsx';
import MapaEquipamento from './Pages/MapaDeEquip/index';
import reportWebVitals from './reportWebVitals';

const routing = (
<BrowserRouter >
    <div>
        <Routes >
            <Route exact path="/"
                element={< Login />}
            /> 
            <Route path="/MapaEquipamento"
                element={< MapaEquipamento />}
            /> <Route path="/ListarEquipamentos"
                element={< ListarEquipamentos />}
            /> 
            <Route path="/Empresas"
                element={< Empresas />}
            />

            <Route path="/NotFound"
                element={< NotFound />}
            />

            <Route path="*"
            element={< Navigate to="/NotFound"
                    replace />}
            />

            </Routes> 
    </div> 
</BrowserRouter>
            );

            ReactDOM.render(routing, document.getElementById('root'))

            // If you want to start measuring performance in your app, pass a function
            // to log results (for example: reportWebVitals(console.log))
            // or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
            reportWebVitals();