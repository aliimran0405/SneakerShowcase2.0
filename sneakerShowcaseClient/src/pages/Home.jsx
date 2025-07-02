import Card from "../Components/Card";
import React, { useEffect, useState } from "react";


function Home(props) {


    // useEffect(() => {
    //     document.title = 'Home';
    // }, []);
    
    const [getSneakers, setGetSneakers] = useState([]);

    useEffect(() => {
        document.title = "Home";
        fetch("/api/sneakers")
            .then(res => res.json())
            .then(data => setGetSneakers(data));
    },  []);
    
    
    return(
        <>
            <div className="home-container">
                <h1>FIND THE PERFECT SNEAKERS FOR YOU</h1>
                <input type="text" value={props.query} onChange={e => props.setQuery(e.target.value)} placeholder="Search for Sneakers"></input>
            </div>
            
            <div className='card-container'>
                {getSneakers.map(item => (
                    <Card key={item.sneakerName} id={item.id} sneakerName={item.sneakerName} shoeImg={`http://localhost:5260${item.shoeImg}`} brandName={item.brandName}/>
                ))}
            </div>
        </>
    );
}

export default Home;