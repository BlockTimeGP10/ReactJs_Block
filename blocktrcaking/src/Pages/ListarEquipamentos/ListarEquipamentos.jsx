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
import './ListarEquipamentos.css';
import Header from "../../Components/Header";
import Footer from "../../Components/Footer"
import MenuLateral from "../../Components/MenuLateral";

function listarEquip() {
    
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
            <Header/>
            <main>
                <MenuLateral/>
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
            <Footer/>
        </>
    );
}
export default listarEquip;