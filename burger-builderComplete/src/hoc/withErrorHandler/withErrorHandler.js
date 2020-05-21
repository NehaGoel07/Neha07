import React,{useState,useEffect} from 'react'
import Aux from '../Auxx/Auxx'
import Modal from '../../components/UI/Modal/Modal'
import useHttpErrorHandler from '../../hooks/http-error-handler'

const withErrorHandler=(WrappedComponent,axios)=>{
    return props=> {

        const [error,clearError]=useHttpErrorHandler(axios);

        // const [error,setError]=useState(null);
        
        //     const resInterceptor=axios.interceptors.response.use(response=>response,err=>{
        //         setError(err)
               
        //     });

        //     const reqInterceptor=axios.interceptors.request.use(request=>{
        //         setError(null);
        //         return request;
        //     });
       

        // useEffect(()=>{
        //     return()=>{
        //         axios.interceptors.request.eject(reqInterceptor);
        //         axios.interceptors.response.eject(resInterceptor);
        //     };
        // },[reqInterceptor,resInterceptor]);

        // const errorConfirmedHandler=()=>{
        //     setError(null);
        // }

        
            return(

                <Aux>
                    <Modal show={error}
                        clicked={clearError}>
                        {error ? error.message:null}
                    </Modal>
                <WrappedComponent {...props}/>
                </Aux>
            )
        }
       
    }

export default withErrorHandler;