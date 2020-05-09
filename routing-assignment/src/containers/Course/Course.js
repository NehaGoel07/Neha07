import React, { Component } from 'react';

class Course extends Component {


    state={
        courseTitle:''
    }

    componentDidMount(){

        this.parseQueryParams();
    }
        parseQueryParams = () => {
            const query = new URLSearchParams(this.props.location.search);
            for( let params of query.entries()){
                if(this.state.courseTitle !== params[1]){
                    this.setState({courseTitle : params[1]});
                }
            }
        }
        
        render () {
        return (
            <div style={{margin:'30px',padding:'20px'}} className="card">
                <h3 className="card-title">COURSE TITLE:{this.state.courseTitle}</h3>
                <p className="card-text">You selected the Course with ID: {this.props.match.params.id}</p>
            </div>
        );
    }
}

export default Course;