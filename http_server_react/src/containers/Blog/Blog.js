import React, { Component ,Suspense} from 'react'
import {Route , Link ,Switch ,Redirect} from 'react-router-dom'
import './Blog.css'
import Posts from './Posts/Posts'
//import asyncComponent from '../../hoc/asyncComponent'
//import NewPost from './NewPost/NewPost'
import FullPost from './FullPost/FullPost'


//Implementing lazy loading,old way(befor 16.6 version)
// const AsyncNewPost=asyncComponent(()=>{
//     return import('./FullPost/FullPost');    //dynamic import syntax,whatever is written inside import(),is only imported when that func is executed and then that func is executed once we render AsyncNewPost
// });

//new way introduced after 16.6 version
const NewPost =React.lazy(()=>import('./NewPost/NewPost'));
class Blog extends Component {


    state={
        auth:false
    }
    render () {

        return (
            <div className="Blog">
                <header>
                    <nav>
                        <ul>
                            <li>
                                {/* <a href="/">Home</a> */}
                                <Link to="/">Home</Link>
                            </li>
                            <li>
                            {/* <a href="/new">New Post</a> */}
                            <Link to="/new">New Post</Link>
                            </li>
                        </ul>
                    </nav>
                </header>

                {/* exact is a boolean property which specify that the routing path 
                should match exactly with the path mentioned,if not written exact
                it is by default false and it will work for every routing which 
                starts with the mentioned path */}
                
                <Switch>
                    {/* <Route path="/" exact render={()=><h1>Hello</h1>}/> */}
                    <Route path="/" exact component={Posts}/>

                    {/* conditionally checking is user is authorize to acces or not */}
                    {/* {this.state.auth?<Route path="/new" exact component={NewPost}/>:null} */}
                    <Route path="/new" exact render={()=>
                    <Suspense fallback={<div>Loading....</div>}>
                        <NewPost/>
                    </Suspense>}/>


                    {/* as our user is not authenticated redirect acts as a navigation guard and takes the control back to home */}
                    {/* <Redirect from='/new' to='/'/>  */}


                    {/* when we want to fetch data on the basis of id,
                        :id means that if we want to pass any information dynamically to our url */}
                    
                    <Route path="/:id" exact component={FullPost}/> 

                    
                    {/* used to handle 404 error as a route without a "to" will handle all the non matching route prior to it */}
                    <Route render={()=><h1>Not Authorized to access this page</h1>}/>

                    
                    
                </Switch>
                
            </div>
        );
    }
}

export default Blog;