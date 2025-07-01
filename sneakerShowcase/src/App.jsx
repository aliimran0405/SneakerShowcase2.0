import Home from './pages/Home.jsx'
import About from './pages/About.jsx';
import ShoePage from './pages/ShoePage.jsx';
import Nav from './Components/Nav.jsx';

import { Route, Routes} from 'react-router-dom';
import React, { useState } from 'react';

import { data } from './Data.jsx';

function App() {

    // Handle search functionality for Search bar inside Nav
    const [query, setQuery] = useState("");

    const getFilteredItems = (query, items) => {
        if (!query) {
            return items;
        }
        return items.filter(sneaker => sneaker.sneakerName.toLowerCase().includes(query.toLowerCase()) || sneaker.brandName.toLowerCase().includes(query)); // allow user to search by sneaker name or brand name
    }
    
    // Filtered items are name of shoes that matches query
    const filteredItems = getFilteredItems(query, data);
    //console.log(filteredItems);

    return(
        <>
            <Nav/>
            <Routes>
                <Route path='/' element={<Home query={query} setQuery={setQuery} data={filteredItems}/>} />
                <Route path='/about' element={<About />} />
                <Route path='/shoe/:shoeId' element={<ShoePage />} />
            </Routes>
        </>
    );
}

// TODO 1: Change map() method from Card component to Home.jsx and add PropTypes so that the component is more reusable
// TODO 2: Add ShoePage functionality
// TODO 3: Check styling

export default App
