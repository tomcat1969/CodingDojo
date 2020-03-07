import React from 'react';

import './App.css';
import {MyComponent} from './components/MyComponent'

function App() {
  return (
    <div className="App">
      <MyComponent movies = {['morma holiday','titanic','american lover','friends']} />
    </div>
  );
}

export default App;

