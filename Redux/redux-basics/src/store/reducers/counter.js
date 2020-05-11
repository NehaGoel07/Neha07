import * as actionType from '../actions'

const initialState={
    counter:0
}

//creating the reducer and setting the state with initial state
const reducer=(state = initialState,action)=>{

    switch(action.type){
        case actionType.INCREMENT:
            return{
                ...state,
                counter:state.counter + 1
            }
        case actionType.DECREMENT:
            return{
                ...state,
                counter:state.counter - 1
            }
        case actionType.ADD:
            return{
                ...state,
                counter:state.counter + action.payload.val
            }
        case actionType.SUBTRACT:
            return{
                ...state,
                counter:state.counter - action.value
            }


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