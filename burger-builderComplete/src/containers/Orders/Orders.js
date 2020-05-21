import React, { useEffect } from 'react'
import Order from '../../components/Order/Order'
import axios from '../../axios-order'
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler'
import * as actions from '../../store/actions/index'
import {connect} from 'react-redux'
import Spinner from '../../components/UI/Spinner/Spinner'

const Orders =props => {
    
    const {onFetchOrders}=props;
    useEffect(()=>{
        onFetchOrders(props.token,props.userId);
    },[onFetchOrders]);


    // componentDidMount(){
    //     console.log(this.props.token);
    //     this.props.onFetchOrders(this.props.token,this.props.userId);

    //     //***********WITHOUT REDUX*********** */
    //     // axios.get('/orders.json')
    //     // .then(response=>{
    //     //     const fetchedOrders=[];
    //     //     for(let key in response.data){
    //     //         fetchedOrders.push({
    //     //             ...response.data[key],
    //     //         id:key
    //     //     });
    //     //     }
    //     //     this.setState({loading:false,orders:fetchedOrders})}
    //     //     ).catch(error=>{
    //     //         this.setState({loading:false})
    //     //     })
    // }
    
        let orders=<Spinner/>
        if(!props.loading){
            orders=(
                props.orders.map(order=>(
                    <Order key={order.id}
                    ingredients={order.ingredients}
                    price={order.price}
                    />
                ))
            )
        }
        return (
            <div>
                {orders}
            </div>
        )
    }


const mapStateToProps=state=>{
    return{
        orders:state.order.orders,
        loading:state.order.loading,
        token:state.auth.token,
        userId:state.auth.userId
    }
};

const mapDispatchToProps= dispatch => {
    return{
        onFetchOrders:(token,userId)=>dispatch(actions.fetchOrders(token,userId))
    };
};

export default connect(mapStateToProps,mapDispatchToProps)(withErrorHandler(Orders,axios));