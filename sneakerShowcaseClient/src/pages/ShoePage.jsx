import { useParams } from "react-router-dom";
import React, { useEffect, useState } from "react";


function ShoePage() {

    const { sneakerId } = useParams();
    const [curSneaker, setCurSneaker] = useState([]);
    //const curSneaker = data.find(x => x.id === sneakerId);
    
    // useEffect(() => {
    //     document.title = curSneaker.sneakerName
    // }, []);

    useEffect(() => {
        fetch(`/api/sneakers/${sneakerId}`)
        .then(res => res.json())
        .then(data => setCurSneaker(data));
    },  []);

    useEffect(() => {
        document.title = curSneaker.sneakerName;
    })

    return(
            <div className="shoe-page-container">
                {console.log("CUR SNK: ", curSneaker)}
                <h1>{curSneaker.sneakerName}</h1>
                <div className="shoe-details">
                    <div className="imgs">
                        <img src={`http://localhost:5260${curSneaker.shoeImg}`} alt={curSneaker.sneakerName} />
                        <img src={`http://localhost:5260${curSneaker.mainImg}`} alt={curSneaker.sneakerName} />
                    </div>
                    <div className="description">
                        <p className="description-text">{curSneaker.description}</p>
                        <a href={curSneaker.link} target="_blank">See official {curSneaker.brandName} store</a>
                    </div>
                </div>
            </div>
        
    );
}

export default ShoePage;