import * as actionType from '../actions'

const initialState={

    results:[]
}

//creating the reducer and setting the state with initial state
const reducer=(state = initialState,action)=>{

    switch(action.type){
        case actionType.STORE_RESULT:
            return{
                ...state,
                results:state.results.concat({id:new Date() , value: action.result})
            }
        case actionType.DELETE_RESULT:
            //METHOD 1
            // const id=2;
            // const newArray=[...state.results];
            // newArray.splice(id,1);

            //METHOD 2
            const updatedArray=state.results.filter(result=>result.id!==action.resultElId)

            return{
                ...state,
                results:updatedArray
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