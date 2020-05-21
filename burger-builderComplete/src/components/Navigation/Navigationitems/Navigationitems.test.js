import React from 'react'
import{configure,shallow} from 'enzyme'
import Adapter from 'enzyme-adapter-react-16'
import NavigationItems from './Navigationitems'
import NavigationItem from './Navigationitem/Navigationitem'

configure({adapter:new Adapter()});

//test suite
describe('<Navigationitems/>',()=>{
    let wrapper;

    //executes before every test and provides the wrapper variable to every test 
    beforeEach(()=>{
        wrapper=shallow(<NavigationItems/>); 
    });

    //test1
    it('should render two <Navigationitem/> elements if not authenticated',()=>{

        //shallow rendering Navigationitems and storing the result in wrapper
        //const wrapper=shallow(<NavigationItems/>); 
       
        /*write the expected ouput,find is a utility function which allows to find a 
        **particular element from the output of shallow render,
        **toHaveLength is also an utility function which specifies how many times we expect that element
        **wrapper.find(NavigationItem) will output in an array and checks if the length if that array is 2 */
        expect(wrapper.find(NavigationItem)).toHaveLength(2);
    });

    //test2
    it('should render three <Navigationitem/> elements if authenticated',()=>{
        //const wrapper=shallow(<NavigationItems isAuthenticated/>); 

        /*with beforeEach we do not have isAuthenticated props thus resulting in failure of test case,
        props are set using setProps() function which accepts a JS object in a key value pair,
        key is the name of the prop we want to pass and value is the value of that prop*/
        wrapper.setProps({isAuthenticated:true});
        expect(wrapper.find(NavigationItem)).toHaveLength(3);
    });

    //test3
    it('should render a <NavigationItem/> for logout functionality',()=>{
        wrapper.setProps({isAuthenticated:true});
        expect(wrapper.contains(<NavigationItem link="/logout">Logout</NavigationItem>)).toEqual(true);
    })
});