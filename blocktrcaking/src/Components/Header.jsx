import React from 'react';


export default function Header (){

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

    return(
        <div>
            <header>
                <hr className="LinhaHeader" />
                <div className="TamanhoHeader">
                    <div className="grid alignLogo">
                        <input className="input-header" id="menu-hamburguer" type="checkbox" />

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
        </div>
    );

}