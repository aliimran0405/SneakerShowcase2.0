import { data } from '../Data';
import { Link } from 'react-router-dom';
import PropTypes from 'prop-types'


function Card(props) {

    // const listItems = data.map(d => <><img src={d.shoeImg}/>
    //                                 <p className='brand-name'>{d.brandName}</p>
    //                                 <p className='sneaker-name'>{d.sneakerName}</p></>
    // );

    return(
       
            
                <Link to={`/shoe/${props.id}`} style={{textDecoration: 'none', color: 'inherit'}}>
                    <div className="card-wrapper" key={props.sneakerName}>
                        <img className="shoe-img" src={props.shoeImg} alt={props.sneakerName} />
                        <p className="brand-name">{props.brandName}</p>
                        <p className="sneaker-name">{props.sneakerName}</p>
                    </div>
                </Link>
            
        
    );
}

Card.propTypes = {
    id: PropTypes.string,
    sneakerName: PropTypes.string,
    shoeImg: PropTypes.string,
    brandName: PropTypes.string,
}

export default Card