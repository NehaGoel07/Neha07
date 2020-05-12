import * as actionType from '../actions/actionTypes'
import {updateObject} from '../utility'

const initialState={
    counter:0
}

//creating the reducer and setting the state with initial state
const reducer=(state = initialState,action)=>{

    switch(action.type){
        case actionType.INCREMENT:
            return updateObject(state,{counter:state.counter + 1})
            // return{
            //     ...state,
            //     counter:state.counter + 1
            // }
        case actionType.DECREMENT:
            return updateObject(state,{counter:state.counter - 1})
            // return{
            //     ...state,
            //     counter:state.counter - 1
            // }
        case actionType.ADD:
            return updateObject(state,{counter:state.counter + action.val})
            // return{
            //     ...state,
            //     counter:state.counter + action.val
            // }
        case actionType.SUBTRACT:
            return updateObject(state,{counter:state.counter - action.value})
            // return{
            //     ...state,
            //     counter:state.counter - action.value
            // }


    }
    return state;
    // if(action.type==='INCREMENT')
    // {
    //     return {
    //         counter:state.counter + 1
    //     }
    // }
    // if(action.type==='DECREMENT')
    // {
    //     return{
    //         counter:state.counter-1
    //     }
    // }
    // if(action.type==='ADD')
    // {
    //     return{
    //         counter:state.counter + action.payload.val //retreiving value sent through payload
    //     }
    // }

    // if(action.type==='SUBTRACT')
    // {
    //     return{
    //         counter:state.counter - action.value
    //     }
    // }
    // return state;
}

export default reducer;