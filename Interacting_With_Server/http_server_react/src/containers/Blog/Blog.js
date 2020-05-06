import React, { Component } from 'react';
import axios from '../../axios'
import Post from '../../components/Post/Post';
import FullPost from '../../components/FullPost/FullPost';
import NewPost from '../../components/NewPost/NewPost';
import './Blog.css';

class Blog extends Component {

    state={
        posts:[],
        selectedPost:null,
        error:false
    }

    postSelectedHandler=(id)=>{
        
        this.setState({selectedPost:id});
        
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
                this.setState({error:true})
            });
    }


    render () {

        if(!this.state.error)
        {
                var posts=this.state.posts.map(post=>{
                return <Post key={post.id} 
                            title={post.title} 
                            author={post.author} 
                            clicked={()=>this.postSelectedHandler(post.id)}/>
            });
        }
        else{
            posts=<p style={{textAlign:'center'}}>Something went wrong!!!!</p>
        }

        return (
            <div>
                <section className="Posts">
                    {posts}
                </section>
                <section>
                    <FullPost id={this.state.selectedPost}/>
                </section>
                <section>
                    <NewPost />
                </section>
            </div>
        );
    }
}

export default Blog;