import React, { Component } from 'react'
import {Route,Switch,Redirect,Link} from 'react-router-dom'
import Courses from '../Courses/Courses';
import Users from '../Users/Users';
import Course from '../Course/Course'
import './Home.css'
import error from '../../Components/404Error'
import App from '../../App'

export default class Home extends Component {
    render() {
        return (
            <div className="Home">
                <header>
                <nav className="navbar navbar-expand-lg navbar-light bg-secondary">
                <ul className="navbar-nav mr-auto">
                    {/* Q2 */}
                    <li className="nav-item">
                        <Link to="/users" className="text-white">Users</Link>
                    </li>
                    <li className="nav-item">
                        <Link to="/Courses" className="text-white">Courses</Link>
                    </li>
                </ul>
            </nav>
            </header>


        <Switch>

          {/* Q1 */}
          <Route path="/users" exact component={Users}/>
          <Route path="/Courses" exact component={Courses}/>

          {/*Q3*/}
          <Route path='/Courses/Course/:id' exact component={Course}/>
          
          {/* Q8 */}
          <Redirect to="/courses" from="/all-courses"/>
          
          {/*Q7*/}
          <Route component={error}/>
          
          <Route to="/" component={App}/>

        </Switch>
        </div>
        )
    }
}
