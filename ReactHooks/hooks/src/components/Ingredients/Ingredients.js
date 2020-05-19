import React ,{useEffect, useCallback,useReducer,useMemo} from 'react';

import IngredientForm from './IngredientForm';
import Search from './Search';
import IngredientList from './IngredientList'
import ErrorModal from '../UI/ErrorModal' 
import useHttp from '../../hooks/http'


const ingredientReducer=(currentIngredients,action)=>{
  switch(action.type){
    case 'SET':
      return action.ingredients;
    case 'ADD':
      return [...currentIngredients,action.ingredient];
    case 'DELETE':
      return currentIngredients.filter(ing=>ing.id!==action.id);
    default:
      throw new Error('Should not get there!');
  }
}


const Ingredients=()=> {

  const [userIngredients,dispatch]=useReducer(ingredientReducer,[]);
  const {isLoading,error,data,sendRequest,reqExtra,reqIdentifier,clear}=useHttp();
  
  //const [userIngredients,setUserIngredients]=useState([]);
  // const [isLoading,setIsLoading]=useState(false);
  // const [error,setError]=useState();

  // useEffect(()=>{
  //     fetch('https://react-hooks-update-c3d77.firebaseio.com/ingredients.json')
  //   .then(response=>response.json())
  //   .then(responseData=>{
  //     const loadedIngredients=[];
  //     for(const key in responseData){
  //       loadedIngredients.push({
  //         id:key,
  //         title:responseData[key].title,
  //         amount:responseData[key].amount
  //       });
  //     }
  //     setUserIngredients(loadedIngredients);
  //   });
  // },[]);

  
  useEffect(()=>{
    if(!isLoading && !error && reqIdentifier==='REMOVE_INGREDIENT'){
      dispatch({type:'DELETE',id:reqExtra});
    }
    else if(!isLoading && !error && reqIdentifier==='ADD_INGREDIENT') {
      dispatch({
        type:'ADD',
        ingredient:{
          id:data.name,
          ...reqExtra
        }
      })
    }
  },[data,reqExtra,reqIdentifier,isLoading,error])

  const addIngredientHandler=useCallback(ingredient =>{
    sendRequest('https://react-hooks-update-c3d77.firebaseio.com/ingredients.json',
    'POST',
    JSON.stringify(ingredient),
    ingredient,
    'ADD_INGREDIENT');
    // //setIsLoading(true);
    // dispatch({type:'SEND'});
    // //fetch will by default select get request
    // fetch('https://react-hooks-update-c3d77.firebaseio.com/ingredients.json',{
    //   method:'POST',
    //   body:JSON.stringify(ingredient),
    //   headers:{'Content-Type':'application/json'}
    // }).then(response=>{
    //   //setIsLoading(false);
    //   dispatch({type:'RESPONSE'});
    //   return response.json();
    // }).then(responseData=>{
    //   // setUserIngredients(prevIngredients=>[...prevIngredients,
    //   //   {id:responseData.name,...ingredient}
    //   // ]);
    //   dispatch({type:'ADD',ingredient:{id:responseData.name,...ingredient}})
    // });
    
  },[sendRequest]);

  const removeIngredientHandler=useCallback(ingredientId=>{
    sendRequest(`https://react-hooks-update-c3d77.firebaseio.com/ingredients/${ingredientId}.json`,
    'DELETE',
    null,
    ingredientId,
    'REMOVE_INGREDIENT');
    //setIsLoading(true);
    //dispatch({type:'SEND'});
   
  
  },[sendRequest]);


  const filteredIngredientsHandler=useCallback(filteredIngredients=>{
    //setUserIngredients(filteredIngredients);
    dispatch({type:'SET',ingredients:filteredIngredients});
  },[]);


  // const clearError=useCallback(()=>{
  //   dispatch({type:'CLEAR'});
  //   // setError(null); 
  //   // setIsLoading(false);
  // },[]);

  const ingredientList=useMemo(()=>{
    return(
      <IngredientList ingredients={userIngredients} onRemoveItem={removeIngredientHandler}/>
    );
  },[userIngredients,removeIngredientHandler]);

  return (
    <div className="App">
      {error && <ErrorModal onClose={clear} >{error}</ErrorModal>}
      <IngredientForm onAddIngredient={addIngredientHandler} loading={isLoading}/>

      <section>
        <Search onLoadIngredients={filteredIngredientsHandler}/>
        {ingredientList}
      </section>
    </div>
  );
}

export default Ingredients;
