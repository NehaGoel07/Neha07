import React, { useState ,useEffect,useCallback} from 'react'
import Aux from '../../hoc/Auxx/Auxx';
import Burger from '../../components/Burger/Burger'
import BuildControls from '../../components/Burger/BuildControls/BuildControls';
import Modal from '../../components/UI/Modal/Modal'
import OrderSummary from '../../components/Burger/OrderSummary/OrderSummary'
import axios from '../../axios-order'
import Spinner from '../../components/UI/Spinner/Spinner'
import withErrorHandler from '../../hoc/withErrorHandler/withErrorHandler'
import {useDispatch,useSelector} from 'react-redux'
import * as actions from '../../store/actions/index'


// const INGREDIENT_PRICES={
//     salad:0.5,
//     meat:1.3,
//     cheese:0.4,
//     bacon:0.7
// }

const BurgerBuilder =props => {

    const [purchasing,setPurchasing]=useState(false);

    const dispatch=useDispatch();

    const onIngredientAdded=(ingName)=>dispatch(actions.addIngredient(ingName));
    const onIngredientRemoved=(ingName)=>dispatch(actions.removeIngredient(ingName));
    const onInitIngredients=useCallback(()=>dispatch(actions.initIngredient()),[dispatch]);
    const onInitPurchase=()=>dispatch(actions.purchaseInit());
    const onSetAuthRedirectPath=(path)=>dispatch(actions.setAuthRedirectPath(path));

    const ings= useSelector(state=>{
        return state.burgerBuilder.ingredients;
    });

    const price= useSelector(state=>{
        return state.burgerBuilder.totalPrice;
    });

    const error= useSelector(state=>{
        return state.burgerBuilder.error;
    });

    const isAuthenticated= useSelector(state=>{
        return state.auth.token!==null;
    });
   
    // state={
        
    //     purchasing:false,
    //     loading:false,
    //     error:false
    // }

    useEffect(()=>{

        onInitIngredients();
        // .then(response=>{
        //     this.setState({ingredients:response.data});

        // }).catch(error=>{
        //     this.setState({error:true})
        // });
    },[onInitIngredients]);

    const updatePurchaseState = (ingredients)=> {
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

    const purchaseHandler=()=>{
        if(isAuthenticated)
        {
            setPurchasing(true);
        }
        else{
            onSetAuthRedirectPath('/checkout');
            props.history.push('/auth') ;
        }
    }

    const purchaseCancelHandler=()=>{
        setPurchasing(false);
    }

    const purchaseContinueHandler=() =>{

        onInitPurchase();
        props.history.push('/checkout');

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

        
    }
    
        const disabledInfo={
            ...ings
        };
        for(let key in disabledInfo)
        {
            disabledInfo[key]=disabledInfo[key]<=0
        }

        let orderSummary=null;

        let burger=error ? <p>Ingredients can't be loaded</p> : null;
        if(ings){

            burger=(
                <Aux>
                <Burger ingredients={ings}/>
                <BuildControls ingredientAdded={onIngredientAdded}
                ingredientRemoved={onIngredientRemoved}
                disabled={disabledInfo}
                price={price}
                purchasable={updatePurchaseState(ings)}
                ordered={purchaseHandler}
                isAuth={isAuthenticated}/>
                </Aux>
                );
                orderSummary=<OrderSummary
                purchaseCanceled={purchaseCancelHandler}
                price={price}
                purchaseContinued={purchaseContinueHandler}
                ingredients={ings}/>
        }

        // if(this.state.loading)
        // {
        //     orderSummary=<Spinner/>;
        // }


        return (
            <Aux>
                <Modal show={purchasing} modalClosed={purchaseCancelHandler}>
                    {orderSummary}
                </Modal>
                {burger}
            </Aux>
        )
    }


// const mapStateToProps=state=>{
//     return{
//         ings:state.burgerBuilder.ingredients,
//         price:state.burgerBuilder.totalPrice,
//         error:state.burgerBuilder.error,
//         isAuthenticated:state.auth.token!==null
//     }
// };

// const mapDispatchToProps=dispatch=>{
//         return{
//             //onIngredientAdded:(ingName)=>dispatch({type:actionTypes.ADD_INGREDIENT ,ingredientName:ingName}),
//             onIngredientAdded:(ingName)=>dispatch(actions.addIngredient(ingName)),
//             //onIngredientRemoved:(ingName)=>dispatch({type:actionTypes.REMOVE_INGREDIENT , ingredientName :ingName})
//             onIngredientRemoved:(ingName)=>dispatch(actions.removeIngredient(ingName)),
//             onInitIngredients:()=>dispatch(actions.initIngredient()),
//             onInitPurchase:()=>dispatch(actions.purchaseInit()),
//             onSetAuthRedirectPath:(path)=>dispatch(actions.setAuthRedirectPath(path))
//         }
//     };

export default (withErrorHandler(BurgerBuilder,axios));