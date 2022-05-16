import React, { useState, useEffect } from 'react';
import axios from 'axios';

import EmpresascCSS from "../Empresas/Empresas.css"
import MenuLateral from "../../Components/MenuLateral";
import Header from "../../Components/Header";
import Footer from "../../Components/Footer";
//import MaisUm from "../../Pages/Assets/MaisUm.svg";


export default function Empresas(){
    const [ ListarEmpresas, setListarEmpresas ] = useState( [] );
    const [ isLoading, setIsLoading ] = useState( false );


    function buscarEmpresas(){
        setIsLoading( true );
        // Faz a chamada para a API usando axios
        axios('http://localhost:5000/api/empresas', {
            headers : {
                'Authorization' : 'Bearer ' + localStorage.getItem('usuario-login')
            }
        })

        // Caso a resposta da requisição retorne um status code 200
        .then(resposta => {
            if (resposta.status === 200) {
                // Chama a função que atualiza o state listaTiposUsuarios
                setListarEmpresas(resposta.data);
                setIsLoading( false );
            };
        })

        // Mostra no console do navegador
        .catch(error => console.log(error));
    };

    return (
        <div>
            <Header/>
            <div className='div-container'>
                <MenuLateral/>
                <main className='conteudoPrincipal'>
                    <section className='sec-nova-empresa'>
                        <div className='div-title'>
                            <h1 className='title'>Empresas</h1>
                        </div>
                        
                        <div className='div-shere-new-empresa'>
                            <div className='div-input'>
                                <input className='input-pesq' type="text" />
                            </div>
                            <button className='btn'>
                                {/* <img className='img-btn' src={MaisUm} alt="" /> */}
                                Nova Empresa
                            </button>    
                        </div>
                    </section>

                    <section className='sec-list'> 
                        <div className="div-list">
                            <table id="tabela-lista">
                                <thead>
                                    <tr className='i'>
                                        <th className='cabec-empresa name-empresa'>Nome</th>
                                        <th className='cabec-empresa'>Contato</th>
                                        <th className='cabec-empresa'>Editar</th>
                                        <th className='cabec-empresa ver-map'>Ver no mapa</th>
                                    </tr>                                    
                                </thead>

                                <div className='simul'>
                                    <h2>olá</h2>
                                </div>

                                <tbody id="tabela-lista-corpo">
                                        {
                                            ListarEmpresas.map( (empresa) => {
                                                return(
                                                    <tr key={empresa.idEmpresa}>
                                                        <td>{empresa.nomeEmpresa}</td>
                                                        <td>{empresa.contato}</td>
                                                        <td>
                                                            <img src="" alt="" />
                                                            <img src="" alt="" />
                                                        </td>
                                                        <td>
                                                            <img src="" alt="" />
                                                        </td>                                                        
                                                    </tr>
                                                );
                                            } )
                                        } 
                                </tbody> 
                            </table>
                        </div>
                    </section>
                </main>               
            </div>
             <Footer/>
        </div>
    )
};