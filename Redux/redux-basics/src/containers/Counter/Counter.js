import React, { Component } from 'react';
import {connect} from 'react-redux'
import CounterControl from '../../components/CounterControl/CounterControl';
import CounterOutput from '../../components/CounterOutput/CounterOutput';
import * as actionType from '../../store/actions'

class Counter extends Component {
    state = {
        counter: 0
    }

    counterChangedHandler = ( action, value ) => {
        switch ( action ) {
            case 'inc':
                this.setState( ( prevState ) => { return { counter: prevState.counter + 1 } } )
                break;
            case 'dec':
                this.setState( ( prevState ) => { return { counter: prevState.counter - 1 } } )
                break;
            case 'add':
                this.setState( ( prevState ) => { return { counter: prevState.counter + value } } )
                break;
            case 'sub':
                this.setState( ( prevState ) => { return { counter: prevState.counter - value } } )
                break;
        }
    }

    render () {
        return (
            <div>
                <CounterOutput value={this.props.ctr} />
                <CounterControl label="Increment" clicked={this.props.onIncrementCounter} />
                <CounterControl label="Decrement" clicked={this.props.onDecrementCounter}  />
                <CounterControl label="Add 5" clicked={this.props.onAdditionCounter}  />
                <CounterControl label="Subtract 5" clicked={this.props.onSubtractionCounter}  />
                <hr/>
                <button onClick={()=>this.props.onStoreResult(this.props.ctr)}>STORE RESULT</button>
                <ul>
                    {this.props.storedResults.map(strResult=>(
                         <li key={strResult.id} onClick={()=>this.props.onDeleteResult(strResult.id)}>{strResult.value}</li>
                    ))}
                   
                </ul>
            </div>
        );
    }
}

//to get access of states so that reducer can use them
const mapStateToProps=(state)=>{

   return{ 
       ctr:state.ctr.counter,
       storedResults:state.res.results 
     };
};

//dispatching the component to the reducer
const mapDispatchToProps=dispatch=>{
    return{
        onIncrementCounter: () => dispatch({type:actionType.INCREMENT}),
        onDecrementCounter:()=>dispatch({type:actionType.DECREMENT}),
        onAdditionCounter:()=>dispatch({type:actionType.ADD ,payload:{val:5}}), //passing value using payload property
        onSubtractionCounter:()=>dispatch({type:actionType.SUBTRACT ,value:5}),
        onStoreResult:(result)=>dispatch({type:actionType.STORE_RESULT ,result : result}),
        onDeleteResult:(id)=>dispatch({type:actionType.DELETE_RESULT , resultElId : id})
    };
}

export default connect(mapStateToProps,mapDispatchToProps)(Counter);