import React, { useState, useEffect } from "react";
import axios from "axios";
import matheus from "../Assets/FotoPerfil.jpeg";
import mapaBranco from "../Assets/MapIconWhite.svg";
import perfilLaranja from "../Assets/perfilBranco.svg";
import noteLaranja from "../Assets/NoteIconOrange.svg";
import InterLaranja from "../Assets/InterIconOrange.svg";
import sairLaranja from "../Assets/icon-sair.svg";
import interact from 'https://cdn.interactjs.io/v1.10.11/interactjs/index.js';
import editar from "../Assets/Editar.svg";
import deletar from "../Assets/Excluir.svg";
import verNoMapa from "../Assets/verMapa.svg";
import './styles.css';

function listarEquip() {

    function botaodomenu() {
        var menu = document.getElementById("mn");
        if (menu.style.display === "flex") {
            //Esconda o menu
            menu.style.display = "none"
        } else {
            //Mostre o menu
            menu.style.display = "flex"
        }
    }

  
    // var listaLugares = [];

    // function listarLugares() {
    //     axios('https://623d99bee8fbc4f16264b76d.mockapi.io/Empresa', {
    //     }).then(resposta => {
    //         if (resposta.status === 200) {
    //             console.log(resposta.data)
    //             listaLugares = (resposta.data)
    //         }
    //     })
    //         .catch(erro => console.log(erro));

    // }

    return (
        <>
            <header>
                <hr className="LinhaHeader" />
                <div className="TamanhoHeader">
                    <div className="grid alignLogo">
                        <input className="input" id="menu-hamburguer" type="checkbox" />

                        <label className="input" htmlFor="menu-hamburguer" onClick={botaodomenu}>
                            <div className="menu">
                                <span className="hamburguer"></span>
                            </div>
                        </label>
                        <div className="LogoHeader">
                            <div className="LogoEscrito">
                                <span className="EscBlock">Blocktime</span>
                                <span className="Proj">Tracking</span>
                            </div>
                            <img src="https://blocktimecoworking.com.br/wp-content/uploads/2019/09/favicon_animado_2-1.gif" alt="" srcSet="" />
                        </div>
                    </div>
                </div>
            </header>
            <main>
                <aside id="mn" className="PainelAdmin">
                    <div className="PrinAside">
                        <div className="partcima">
                            <div className='partFoto'>
                                <img className="FotoPerfil" src={matheus} alt="" srcSet="" />
                                <span id="pessoa">Olá, Matheus Gonçalves</span>
                            </div>
                            <nav className="navigationPainel">
                                <a href="/">
                                    <div className="cardSec">
                                        <div>
                                            <img src={perfilLaranja} alt="" srcSet="" />
                                        </div>
                                        <span>Perfil</span>
                                    </div>
                                </a>
                                <a href="/">
                                    <div className="cardSec selecionado">
                                        <div>
                                            <img src={mapaBranco} alt="" srcSet="" />
                                        </div>
                                        <span>Map. Geral</span>
                                    </div>
                                </a>
                                <a href="/">
                                    <div className="cardSec">
                                        <div>
                                            <img src={InterLaranja} alt="" srcSet="" />
                                        </div>
                                        <span>Map. Empresa</span>
                                    </div>
                                </a>
                                <a href="/">
                                    <div className="cardSec">
                                        <div>
                                            <img src={noteLaranja} alt="" srcSet="" />
                                        </div>
                                        <span>Admin. Equipamentos</span>
                                    </div>
                                </a>
                                <a href="/">
                                    <div className="cardSec">
                                        <div>
                                            <img src={InterLaranja} alt="" srcSet="" />
                                        </div>
                                        <span>Admin. Empresa</span>
                                    </div>
                                </a>
                            </nav>
                        </div>
                        <nav className="navigatio2">
                            <a className="Sair" href="/">
                                <div className="desisto">
                                    <div >
                                        <img src={sairLaranja} alt="" srcSet="" />
                                    </div>
                                    <span>Sair</span>
                                </div>
                            </a>
                        </nav>
                    </div>
                </aside>
                <div className="RealMain">
                    <div className="AjeitarMain">
                        <span>
                            Equipamentos
                        </span>
                        <table>
                            <thead>
                                <tr>
                                    <th>Empresa</th>
                                    <th>Contato</th>
                                    <th>Editar</th>
                                    <th>Ver no mapa</th>
                                </tr>
                            </thead>
                            <tbody>

                            </tbody>
                        </table>
                        <div className="BackgroundMap resize-drag">
                            <div id="map" />
                        </div>
                    </div>
                </div>
            </main>
            <footer>
                <div className="LogoFooter">
                    <img src="https://blocktimecoworking.com.br/wp-content/uploads/2019/09/favicon_animado_2-1.gif" alt="" srcSet="" />
                    <div className="LogoEscrito2">
                        <span className="EscBlock">Blocktime</span>
                        <span className="Proj">Tracking</span>
                    </div>
                </div>
            </footer>
        </>
    );
}


export default listarEquip