import React, { useState } from 'react';
import logo from './logo.svg';
import './App.css';
import Header from './Header';
import BowlerList from './Bowlers/BowlerList';


function App() {
  return (
    <div className="App">
      <Header title="Lilian's Mission 10" />
      <BowlerList />
    </div>
  );
}

export default App;
