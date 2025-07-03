import Card from "../Components/Card";
import React, { useEffect, useState } from "react";


function Home() {


    // useEffect(() => {
    //     document.title = 'Home';
    // }, []);
    
    const [getSneakers, setGetSneakers] = useState([]);
    const [query, setQuery] = useState("");

    useEffect(() => {
        fetch("/api/sneakers")
        .then(res => res.json())
        .then(data => setGetSneakers(data));
        document.title = "Home";
    },  []);
    

    const getFilteredItems = (query, items) => {
        if (!query) {
            return items;
        }
        return items.filter(sneaker => sneaker.sneakerName.toLowerCase().includes(query.toLowerCase()) || sneaker.brandName.toLowerCase().includes(query)); // allow user to search by sneaker name or brand name
    }
    
    //Filtered items are name or brand name of shoes that matches query
    const filteredItems = getFilteredItems(query, getSneakers);
    //console.log(filteredItems);
    
    
    return(
        <>
            <div className="home-container">
                <h1>FIND THE PERFECT SNEAKERS FOR YOU</h1>
                <input type="text" value={query} onChange={e => setQuery(e.target.value)} placeholder="Search for Sneakers"></input>
            </div>
            
            <div className='card-container'>
                {filteredItems.map(item => (
                    <Card key={item.sneakerName} id={item.id} sneakerName={item.sneakerName} shoeImg={`http://localhost:5260${item.shoeImg}`} brandName={item.brandName}/>
                ))}
            </div>
        </>
    );
}

export default Home;