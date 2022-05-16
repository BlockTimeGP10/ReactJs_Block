import React from "react";
import LoginCSS from "../../Pages/Login/Login.css";
import ImgBemvindo from "../Assets/Bemvindo-tela-login.svg";
import LogoBlocktiem from "../Assets/logo-blocktime-tela-login.svg"


export default function Login() {

    return (
        <div className="Container-tela-login">
            <div className="Container-login">
                <div className="Logo-blocktime">
                    <img className="Logo-blocktime-img" src={LogoBlocktiem} alt="Logo da Blacktime, escrito o nome blocktime e com cubos laranja e azul" />
                </div>
                {/* <h1>Login</h1> */}
                <input className="Input-credencial inputs" type="text" />
                <input className="Input-senha inputs" type="text" />
                <button className="btn-login">Login</button>
            </div>

            <div className="Container-logo-bemvindo">
                <img className="img-bemvindo" src={ImgBemvindo} alt="Imagem de bem vindo" />
            </div>
        </div>
    )
};