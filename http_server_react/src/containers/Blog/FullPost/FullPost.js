import React, { Component } from 'react';
import axios from 'axios'
import './FullPost.css';

class FullPost extends Component {


    state={
        loadedPost:null,
        deletedPost:null,
        error:false
    }
    componentDidMount(){
        // here this.props.id will not work,as at the time of mounting we get the route props which have match,
        // which further have params which contains the parameter that is passed with the url
        
        if(this.props.match.params.id)        
       { 
           if(!this.state.loadedPost ||(this.state.loadedPost.id!==this.props.id && this.state.loadedPost))
           {
                axios.get("/posts/"+this.props.match.params.id)
                    .then(response=> 
                    this.setState({loadedPost:response.data})
                )
            }
        }
    }

    deletePostHandler=()=>{

        if(this.props.id){
        axios.delete("/posts/"+this.props.id)
                    .then(response=> {
                        this.setState({deletedPost:response});
                            console.log(response);
                    }
                )
        }
    }

    render () {
        let post = <p style={{textAlign:"center"}}>Please select a Post!</p>;

        if(this.props.id)
        {
             post = <p style={{textAlign:"center"}}>Loading...</p>;
        }
        if(this.state.loadedPost)
        {
            post = (
                    <div className="FullPost">
                        <h1>{this.state.loadedPost.title}</h1>
                        <p>{this.state.loadedPost.body}</p>
                        <div className="Edit">
                            <button className="Delete" onClick={this.deletePostHandler}>Delete</button>
                        </div>
                    </div>
            );
        }
        return post;
    }
}

export default FullPost;