import Card from "../Components/Card";
import React, { useEffect } from "react";
import { data } from "./../Data";


function Home(props) {

    useEffect(() => {
        document.title = 'Home';
    }, []);

    
    return(
        <>
            <div className="home-container">
                <h1>FIND THE PERFECT SNEAKERS FOR YOU</h1>
                <input type="text" value={props.query} onChange={e => props.setQuery(e.target.value)} placeholder="Search for Sneakers"></input>
            </div>
            <div className='card-container'>
                {props.data.map(item => (
                    <Card key={item.sneakerName} id={item.id} sneakerName={item.sneakerName} shoeImg={item.images.shoeImg} brandName={item.brandName}/>
                ))}
            </div>
        </>
    );
}

export default Home;