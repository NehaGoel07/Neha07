import React, { Component } from 'react';
import {BrowserRouter} from 'react-router-dom';
import './App.css'
import 'bootstrap/dist/css/bootstrap.min.css';
import Home from './containers/Home/Home'

class App extends Component {
  render () {
    return (

      <div >

    
    {/* ##############Question List############# */}
        {/* <ol style={{textAlign: 'left'}} className="list-group">
          <li className="list-group-item">Q1:Add Routes to load "Users" and "Courses" on different pages (by entering a URL, without Links)</li>
          <li className="list-group-item">Q2:Add a simple navigation with two links => One leading to "Users", one leading to "Courses"</li>
          <li className="list-group-item">Q3:Make the courses in "Courses" clickable by adding a link and load the "Course" component in the place of "Courses" (without passing any data for now)</li>
          <li className="list-group-item">Q4:Pass the course ID to the "Course" page and output it there</li>
          <li className="list-group-item">Q5:Pass the course title to the "Course" page - pass it as a param or score bonus points by passing it as query params (you need to manually parse them though!)</li>
          <li className="list-group-item">Q6:Load the "Course" component as a nested component of "Courses"</li>
          <li className="list-group-item">Q7:Add a 404 error page and render it for any unknown routes</li>
          <li className="list-group-item">Q8:Redirect requests to /all-courses to /courses (=> Your "Courses" page)</li>
        </ol> */}

        <BrowserRouter>
        <div>
          <Home/>
        </div>
      </BrowserRouter>
        
      </div>
    );
  }
}

export default App;
