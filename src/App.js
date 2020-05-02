import React, { Component } from 'react';
import './App.css';
import Table from './Tables';
import Form from './Form';


class App extends Component {
  constructor() {
    super();

    this.state = {
      userInput:'',
      fruits: []
    }
  };
//-----------------------------handle the input change----------------------------------------------
  handleInputChange = (e) => {
    
    let fruitDetails = e.target.value;
    
    this.setState({
      userInput: fruitDetails
      })
  };

  //-----------------------------handle the submition---------------------------------------------------

  handleFormSubmit = (e) => 
  {
    e.preventDefault();
    
    if (this.state.userInput.length === 0) {
      alert('Enter some data!');
      return;
    }
    const userInput= this.state.userInput.split('-');
    
    if(userInput[0].match(/^[A-Za-z]+$/) && userInput[1].match( /^[0-9]+$/))
    {
      const fruitDetails = {
        name: userInput[0],
        quantity: userInput[1]
      }

      let fruitsList = [...this.state.fruits];
      fruitsList.push(fruitDetails);

      this.setState({
        fruits: fruitsList,
        userInput:''
      });

      
    }
    else{
      alert("enter valid input");
    }

  };
//-----------------------------------------handle the delete operation-----------------------------------
  handleDeleteChange=(id)=>{
    const fruitIndex=this.state.fruits.findIndex(name=>{
        return name.id===id;
    });

    const fruits=[...this.state.fruits];
    fruits.splice(fruitIndex,1);
    this.setState({fruits:fruits});
 }

  
  render() {
    return (
      <div className="App">
        <h1>Assignment of React</h1>
        <hr/>
        
        <Form handleFormSubmit={this.handleFormSubmit} 
          handleInputChange={ this.handleInputChange }
          newName={ this.state.userInput }
           />
        <br/>
        <Table items={this.state.fruits }
        handleDeleteChange={this.handleDeleteChange}
        />
        
      </div>
    );
  }
}

export default App;

