import React, { Component } from 'react'
import axios from '../../../axios'
import Post from '../../../components/Post/Post'
import './Posts.css'
import {Link} from 'react-router-dom'

class Posts extends Component{

    state={
        posts:[]
    }
    
    postSelectedHandler=(id)=>{
        
        this.setState({selectedPost:id});
        //this.props.history.push('/'+id);
        
    }

    componentDidMount(){
        axios.get('/posts')
        .then(
            response=>{
            const posts=response.data.slice(0,4); //transforming the data,to display only 4 records
            const updatedPosts=posts.map(post=>{
                return {
                    ...post,
                    author:'Max'
                }
            });
            this.setState({posts:updatedPosts})}
            ).catch(error=>{
                console.log(error)
                //this.setState({error:true})
            });
    }

    render(){
        if(!this.state.error)
        {
            var posts=this.state.posts.map(post=>{
            return (
                
                    <Link to={'/' + post.id} key={post.id}>
                    <Post  
                        //key={post.id}
                        title={post.title} 
                        author={post.author} 
                        clicked={()=>this.postSelectedHandler(post.id)}/>
                    </Link>);
            });
        }
    
        else{
            posts=<p style={{textAlign:'center'}}>Something went wrong!!!!</p>
        }
        return(
                <section className="Posts">
                    {posts}
                </section>
        );
    }
}

export default Posts;