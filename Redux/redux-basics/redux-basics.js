//redux using node

const redux=require('redux'); //node syntax
const createStore=redux.createStore;

const initialState={
    counter:0
}

//reducer
const rootReducer=(state=initialState,action)=>{
    if(action.type==='INC_COUNTER'){
        return{
            ...state,
            counter:state.counter + 1
        }
    }
    if(action.type==='ADD_COUNTER'){
        return{
            ...state,
            counter:state.counter + action.value
        }
    }
    return state;
}

//store
const store=createStore(rootReducer);
console.log(store.getState());

//subscription
store.subscribe(()=>{
    console.log('[SUBSCRIPTION]',store.getState()); //executes automatically whenever our state changes
});

//action
store.dispatch({type:"INC_COUNTER"});   //type is must in action
store.dispatch({type:"ADD_COUNTER" , value:10});

