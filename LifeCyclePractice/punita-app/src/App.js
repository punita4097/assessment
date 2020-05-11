import React,{Component} from 'react';
import './App.css';
import Student from './Student';

class App extends Component{

  constructor(){
    super();
    console.log("Construtor of mounting process of App is called");
    this.state={
      name:'punita'
    };
  }
  componentDidMount(){
    console.log('coponent did mount called');
  }

  static getDerivedStateFromProps(props,state){
   
    console.log("this is get Derived state from props -II stage");
    console.log(props,state);
    return null;
  }

  componentWillUnmount()
  {
    console.log("app-component will unmount will called");
  }
render(){

    console.log("App-rendered");
    return(

        <div>
          
        <h1 className="App">Lifeline Methods Practice</h1>
        <hr/>
        <Student name={this.state.name}/>
        </div>
      )
 }}

 export default App;