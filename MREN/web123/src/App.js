import React from 'react';
import SomeClassComponent from './components/SomeClassComponent';
import PersonCard from './components/PersonCard';
import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      
      <h2>hello, react</h2>
      <SomeClassComponent/>
      <PersonCard firstName = "Doe" lastName="Jane" age={45} hairColor="Black"/>
      <PersonCard firstName = "Doe" lastName="Jane" age={45} hairColor="Black"/>
      <PersonCard firstName = "Doe" lastName="Jane" age={45} hairColor="Black"/>
      
    </div>
  );
}

export default App;
