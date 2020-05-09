import React, { Component } from 'react';
import {BrowserRouter} from 'react-router-dom'
import Blog from './containers/Blog/Blog';

class App extends Component {
  render() {
    return (

      //by wrapping the div in browser router now routing can be configured anywhere in this div 
      <BrowserRouter>
        <div className="App">
          <Blog />
        </div>
      </BrowserRouter>
    );
  }
}

export default App;
