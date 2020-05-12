import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import registerServiceWorker from './registerServiceWorker';
import {createStore ,combineReducers , applyMiddleware , compose} from 'redux';
import counterReducer from './store/reducers/counter'
import resultReducer from './store/reducers/result'
import {Provider} from 'react-redux'
import thunk from 'redux-thunk'

const rootReducer=combineReducers({
    ctr:counterReducer,
    res:resultReducer
})

const commposeEnhancers=window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__ || compose;

//adding middleware
const logger=store=>{
    return next=>{
        return action=>{
            console.log('[Middleware] dispatching',action);
            const result=next(action);
            console.log('[Middleware] next state',store.getState());
            return result;
        }
    }
}

//creating central store and passing the reducer as a parameter also adding middleware to the store
const store=createStore(rootReducer,commposeEnhancers(applyMiddleware(logger,thunk))); 


ReactDOM.render(<Provider store={store}><App /></Provider>, document.getElementById('root')); //binding our app with the store
registerServiceWorker();
