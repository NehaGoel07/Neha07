import React, { Component } from 'react';
import {Route ,Link} from 'react-router-dom';
import './Courses.css';
import Course from '../Course/Course';


class Courses extends Component {
    state = {
        courses: [
            { id: 1, title: 'Angular - The Complete Guide' },
            { id: 2, title: 'Vue - The Complete Guide' },
            { id: 3, title: 'PWA - The Complete Guide' }
        ]
    }

    render () {
        return (
            <div className="card">
                
                <h1>Amazing Udemy Courses</h1>
                <section className="Courses">
                   {
                        this.state.courses.map( course => {
                        return (
                                <Link to={{
                                    pathname:this.props.match.url + '/Course/' + course.id, //Q4
                                    search:'?title=' +  course.title //Q5
                                }}
                                key={course.id}>
                                <article className="card-body" style={{border:"1px solid black" ,margin:'10px'}}>{course.title}</article>
                                </Link>
                            );
                        })
                   }
                </section>

                {/* for Q6 */}
                <Route path={this.props.match.url + "/Course/:id"} component={Course}/>
            </div>
        );
    }
}

export default Courses;