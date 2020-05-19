import {useReducer,useCallback} from 'react';

const initialState={
    loading:false,
    error:null,
    data:null,
    extra:null,
    identifier:null
};
const httpReducer=(currentHttpState,action)=>{
    switch(action.type)
    {
      case 'SEND':
        return {loading:true,error:null,data:null,extra:null,identifier:action.identifier};
      case 'RESPONSE':
        return {...currentHttpState,loading:false,data:action.responseData,extra:action.extra};
      case 'ERROR':
        return {loading:false,error:action.errorMessage};
      case 'CLEAR':
          return initialState;
      default:
        throw new Error('Should not be reached!');
      
    }
  };

const useHttp = () =>{
    const [httpState,dispatchHttp]=useReducer(httpReducer,initialState);

    const clear=useCallback(()=>dispatchHttp({type:'CLAER'}),[]);
    const sendRequest=useCallback((url,method,body,reqExtra,reqIdentifier)=>{
    dispatchHttp({type:'SEND',identifier:reqIdentifier});
    fetch(url,{
        method:method,
        body:body,
        headers:{
            'Content-Type':'application/json'
        }
      }).then(response=>{
       return response.json();
        //setIsLoading(false);
        // setUserIngredients(prevIngredients=>
        //   prevIngredients.filter(ingredient=>ingredient.id!==ingredientId));
        //dispatch({type:'DELETE',id:ingredientId});
      }).then(responseData=>{
          dispatchHttp({type:'RESPONSE',responseData:responseData,extra:reqExtra})
      }).catch(error=>{
        dispatchHttp({type:'ERROR',errorMessage:console.error.message});
        //setError(error.message);
      });
    },[]);
    return {
        isLoading:httpState.loading,
        data:httpState.data,
        error:httpState.error,
        sendRequest:sendRequest,
        reqExtra:httpState.extra,
        reqIdentifier:httpState.identifier,
        clear:clear
    };
};


export default useHttp;