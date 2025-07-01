import React, { useEffect, useState } from "react";

function About() {

    useEffect(() => {
        document.title = "About";
    }, []);

    const [isAbout, setIsAbout] = useState(true);
    
    const aboutText = <p>Welcome to <b>Sneaker Showcase</b>, your ultimate destination for discovering the latest and greatest in sneaker fashion. We're a curated platform designed for sneaker enthusiasts who love exploring styles across top brands like Nike, Adidas, and more. Whether you're a casual shopper or a serious collector, Sneaker Showcase helps you browse a wide range of sneakers with ease. Our mission is to make sneaker discovery enjoyable and accessible, all in one place.
                        At Sneaker Showcase, we highlight detailed visuals and key features so users can compare styles and brands effortlessly. We're not a store—we're a showcase. Think of us as your digital sneaker gallery, perfect for inspiration, research, and admiration. Step in, scroll through, and stay inspired by the world of sneakers.
                      </p>;
    const developerText = <p>This simple <i>"front end only"</i> project is my first web-application built with React in my journey of becoming a full-stack developer using <u>industry standard</u> tools. The project demonstrates the use of 
                            core concepts of React such as JSX, Components, Routing, Stateful Variables and React Hooks. As this project demonstrates the basic concepts of React, I will be delving deeper into this JavaScript library and also explore Backend server handling in future projects.<br/><br/>
                            Please note that the "mens" and "womens" navbar buttons are purely aesthetic, and that this web-application is only optimized for desktop devices only.
                          </p>;
    

    function handleDisplayedText() {
        setIsAbout(prev => !prev);
    }
    
    return(
        <div className="about-us-container">
            <div className="about-text-area">
                {isAbout ? aboutText : developerText}
                <button className="change-text-button" onClick={handleDisplayedText}>{isAbout ? "See Developer Note" : "About Us"}</button>
            </div>
        </div>
    );
}

export default About;