import React, { useState} from "react";
import { data } from "./../Data";


function Nav(props) {
        

    return(
        <div className="nav-container">
                <a className="logo" href="/">Sneaker Showcase</a>
                <ul className="nav-links">
                    <li><a href="/">Home</a></li>
                    <li><a href="/about">About</a></li>
                    <li><a>Mens</a></li>
                    <li><a>Womens</a></li>
                </ul>
                <div className="nav-spacer"></div>
            
        </div>
    );
}

export default Nav