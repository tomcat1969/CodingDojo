import React from 'react';

import './App.css';
import { Navbar } from './components/Navbar';
import {PokemonApi} from './components/PokemonApi'
function App() {
  return (
    <div className="App">
      <Navbar/>

      <p>******************</p>
      <PokemonApi/>
    </div>
  );
}

export default App;
