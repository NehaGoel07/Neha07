import React, { Component } from 'react';
import axios from 'axios'
import './NewPost.css';
import {Redirect} from 'react-router-dom'

class NewPost extends Component {
    state = {
        title: '',
        content: '',
        author: 'Max',
        error:false,
        submitted:false
    }

    postDataHandler=()=>{

        const newPost={
            title:this.state.title,
            content:this.state.content,
            author:this.state.author
        };

        axios.post("/posts",newPost)
        .then(response=>{
            console.log(response);


            //this.props.history.push('/'); => allows to go back in a page as it adds a new entry in the stack
            this.props.history.replace('/'); //do not allow to go back in a page once redirect just like <Redirect> as it replaces the entry in the stack
            // this.setState({submitted:true})
        })
        .catch(error=>{
            this.setState({error:true})
            alert('Something went wrong!!')
        });

        this.setState(
            {
                title:'',
                content:'',
                author:'Max'
            })
    }
    render () {

        //to redirect to home page when new post is added,another way to redirect to a page 
        // let submit=null;
        // if(this.state.submitted)
        // {
        //     submit=<Redirect to="/"/>
        // }
        return (
            
            <div className="NewPost">
                <h1>Add a Post</h1>
                {/* {submit} */}
                <label>Title</label>
                <input type="text" value={this.state.title} onChange={(event) => this.setState({title: event.target.value})} />
                <label>Content</label>
                <textarea rows="4" value={this.state.content} onChange={(event) => this.setState({content: event.target.value})} />
                <label>Author</label>
                <select value={this.state.author} onChange={(event) => this.setState({author: event.target.value})}>
                    <option value="Max">Max</option>
                    <option value="Manu">Manu</option>
                </select>
                <button onClick={this.postDataHandler} >Add Post</button>
            </div>
        );
    }
}

export default NewPost;