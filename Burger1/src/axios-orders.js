import axios from 'axios';

const instance=axios.create({
    baseURL:'https://react-my-burger-3a2ef.firebaseio.com/'
});

export default instance;