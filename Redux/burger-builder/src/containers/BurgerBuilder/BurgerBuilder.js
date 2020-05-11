import React, { Component } from 'react'
import Aux from '../../hoc/Auxx/Auxx';
import Burger from '../../components/Burger/Burger'
import BuildControls from '../../components/Burger/BuildControls/BuildControls';
import Modal from '../../components/UI/Modal/Modal'
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary'
import axios from '../../axios-order'
import Spinner from '../../components/UI/Spinner/Spinner'
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler'
import {connect} from 'react-redux'
import * as actionTypes from '../../store/actions'


// const INGREDIENT_PRICES={
//     salad:0.5,
//     meat:1.3,
//     cheese:0.4,
//     bacon:0.7
// }

class BurgerBuilder extends Component {

    state={
        
        purchasing:false,
        loading:false,
        error:false
    }

    componentDidMount(){
        // axios.get('https://burger-builder-bd369.firebaseio.com/ingredients.json')
        // .then(response=>{
        //     this.setState({ingredients:response.data});

        // }).catch(error=>{
        //     this.setState({error:true})
        // });
    }

    updatePurchaseState (ingredients) {
        const sum=Object.keys(ingredients)
        .map(igKey=>{
            return ingredients[igKey];
        })
        .reduce((sum,el)=>{
            return sum +el ;
        },0);
        // this.setState({purchasable:sum>0});
        return sum > 0;

    }

    // addIngredientHandler=(type)=>{
    //     const oldCount=this.state.ingredients[type];
    //     const updateCount=oldCount+1;
    //     const updatedIngredients={
    //         ...this.state.ingredients
    //     };
    //     updatedIngredients[type]=updateCount;
    //     const priceAddition=INGREDIENT_PRICES[type];
    //     const oldPrice=this.state.totalPrice;
    //     const newPrice= oldPrice + priceAddition;
    //     this.setState({totalPrice:newPrice,ingredients:updatedIngredients});
    //     this.updatePurchaseState(updatedIngredients);
    // }

    // removeIngredientHandler=(type)=>{
    //     const oldCount=this.state.ingredients[type];
    //     if(oldCount<=0)
    //     {
    //         return ;
    //     }
    //     const updateCount=oldCount-1;
    //     const updatedIngredients={
    //         ...this.state.ingredients
    //     };
    //     updatedIngredients[type]=updateCount;
    //     const priceDeduction=INGREDIENT_PRICES[type];
    //     const oldPrice=this.state.totalPrice;
    //     const newPrice= oldPrice - priceDeduction;
    //     this.setState({totalPrice:newPrice,ingredients:updatedIngredients});
    //     this.updatePurchaseState(updatedIngredients);
    // }

    purchaseHandler=()=>{
        this.setState({purchasing:true});
    }

    purchaseCancelHandler=()=>{
        this.setState({purchasing:false})
    }

    purchaseContinueHandler=() =>{

        // this.setState({loading:true})
        // //alert('You continue');
        // const order={
        //     ingredients:this.state.ingredients,
        //     price:this.state.totalPrice,
        //     customer:{
        //         name:'Neha',
        //         email:'neha@gmail.com',
        //         address:{
        //             street:'test',
        //             zipCode:'12345',
        //             country:'India'
        //         },
        //         deliveryMethod:'fastest'
        //     }
        // }
        // axios.post('/orders.json',order)
        // .then(response=>
        //     this.setState({loading:false,purchasing:false}))
        //     .catch(error=>this.setState({loading:false,purchasing:false})
        //     );

        const queryParams=[];
        // for(let i in this.state.ingredients)
        // {
        //     queryParams.push(encodeURIComponent(i) + '=' + encodeURIComponent(this.state.ingredients[i]));
        // }
        // queryParams.push('price=' + this.state.totalPrice);
        // const queryString=queryParams.join('&');
        // this.props.history.push({
        //     pathname:'/checkout',
        //     search:'?'+queryString
        // });

        this.props.history.push('/checkout');[]
    }
    render() {
        const disabledInfo={
            ...this.props.ings
        };
        for(let key in disabledInfo)
        {
            disabledInfo[key]=disabledInfo[key]<=0
        }

        let orderSummary=null;

        let burger=this.state.error ? <p>Ingredients can't be loaded</p> : null;
        if(this.props.ings){

            burger=(
                <Aux>
                <Burger ingredients={this.props.ings}/>
                <BuildControls ingredientAdded={this.props.onIngredientAdded}
                ingredientRemoved={this.props.onIngredientRemoved}
                disabled={disabledInfo}
                price={this.props.price}
                purchasable={this.updatePurchaseState(this.props.ings)}
                ordered={this.purchaseHandler}/>
                </Aux>
                );
                orderSummary=<OrderSummary
                purchaseCanceled={this.purchaseCancelHandler}
                price={this.props.price}
                purchaseContinued={this.purchaseContinueHandler}
                ingredients={this.props.ings}/>
        }

        if(this.state.loading)
        {
            orderSummary=<Spinner/>;
        }


        return (
            <Aux>
                <Modal show={this.state.purchasing} modalClosed={this.purchaseCancelHandler}>
                    {orderSummary}
                </Modal>
                {burger}
            </Aux>
        )
    }
}

const mapStateToProps=state=>{
    return{
        ings:state.ingredients,
        price:state.totalPrice
    }
};

const mapDispatchToProps=dispatch=>{
        return{
            onIngredientAdded:(ingName)=>dispatch({type:actionTypes.ADD_INGREDIENT ,ingredientName:ingName}),
            onIngredientRemoved:(ingName)=>dispatch({type:actionTypes.REMOVE_INGREDIENT , ingredientName :ingName})
        }
    };

export default connect(mapStateToProps,mapDispatchToProps)(withErrorHandler(BurgerBuilder,axios));