import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import ListarEquip from './Pages/ListarEquipamentos';
import MapaEquipamento from './Pages/MapaDeEquip/index';
import reportWebVitals from './reportWebVitals';
import {
  Route,
  BrowserRouter,
  Routes,
} from 'react-router-dom';

const routing = (
  <BrowserRouter>
    <div>
      <Routes>
        <Route path="/" element={<App/>}/>
        <Route path="/MapaEquipamento" element={<MapaEquipamento/>}/>
        <Route path="/ListarEquipamento" element={<ListarEquip/>}/>
      </Routes>
    </div>
  </BrowserRouter>
);      

ReactDOM.render(routing, document.getElementById('root'))

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();