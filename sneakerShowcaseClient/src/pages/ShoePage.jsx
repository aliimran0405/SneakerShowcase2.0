import { useParams } from "react-router-dom";
import React, { useEffect } from "react";


function ShoePage() {

    
    const { sneakerId } = useParams();
    const curSneaker = data.find(x => x.id === sneakerId);
    
    useEffect(() => {
        document.title = curSneaker.sneakerName;
    }, []);

    return(
            <div className="shoe-page-container">
                <h1>{curSneaker.sneakerName}</h1>
                <div className="shoe-details">
                    <div className="imgs">
                        <img src={curSneaker.images.shoeImg} alt={curSneaker.sneakerName} />
                        <img src={curSneaker.images.mainImg} alt={curSneaker.sneakerName} />
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