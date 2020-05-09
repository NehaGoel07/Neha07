import axios from 'axios'


const instance=axios.create({
    baseURL:'https://burger-builder-bd369.firebaseio.com/'
});

export default instance;