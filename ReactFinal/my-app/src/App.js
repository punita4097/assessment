import React,{Component} from 'react';
import logo from './logo.svg';
import classes from'./App.module.css';
import styled from 'styled-components';
import Person from './Person/Person';

// const StyledButton=styled.button`
//     background-color:  ${ props => props.alt?'red':'green'};
//     color: white;
//     font: inherit;
//     border: 1px solid blue;
//     padding: 8px;

//     &:hover {
//       background-color: ${ props => props.alt?'orange':'lightgreen'};
//       color: black;
//     }

// `;

class App extends Component {

  state={
    persons:[
      {id:"as1",name:'punita',age:23},
      {id:"as2",name:'max',age:26},
      {id:"as3",name:'pooja',age:12}

              
    ],
    showPersons:false
  }  

  // switchNameHandler=()=>
  // {
  //   //console.log('was clicked');
  //   this.setState(
  //     {

  //       persons:[
  //         {name:'punita yadav',age:23},
  //         {name:'max',age:29}
  //       ]
  //     }
  //   )
  // }
deletePersonsHandler=(personIndex)=>
{
  const persons=[...this.state.persons];
  persons.splice(personIndex,1);
  this.setState({persons: persons});
}


  nameChangedhandler=(event,id)=>
  {
    const personIndex=this.state.persons.findIndex(p=>{
      return p.id===id;
    });

    const person=
    {
    ...this.state.persons[personIndex]
  };
  //we can write uisng object.assign in place of spread operator but not good practice

 // const person=Object.assign({},this.state.persons[personIndex]);

  person.name=event.target.value;

  const persons=[...this.state.persons];
  persons[personIndex]=person;
      
    this.setState(
      {

        persons:persons
        // [
        //   {name:'punita yadav',age:23},
        //   {name:event.target.value,age:29}
        // ]
      }
    )
  }

  togglePersonsHandler=()=>
  {
    const doesShow=this.state.showPersons;
    this.setState({showPersons: !doesShow});
  }
  
  render(){

    const style={
      backgroundColor:"green",
      color:"white",
      font:"inherit",
      border:"1px solid blue",
      padding:"8px",
      ':hover':{
        backgroundColor:'lightgreen',
        color:'black'
      }


    };

    let persons=null;
    let btnClass=[classes.Button];
    if(this.state.showPersons)
    {
      persons=(
        <div>
          {this.state.persons.map((persons,index)=>
          {
            return <Person
            click={() => this.deletePersonsHandler(index)}
            name={persons.name}
            age={persons.age}
            key={persons.id}
            changed={(event)=>this.nameChangedhandler(event,persons.id)}
            />

          })} 
       {/* <Person 
      name={this.state.persons[0].name}
       age={this.state.persons[0].age}>my hobbies is crafting</Person>

      <Person name={this.state.persons[1].name}
       age={this.state.persons[1].age}
       changed={this.nameChangedhandler}>my hobbies is crafting</Person>  */}
       </div>
      );

      style.backgroundColor="blue";
      style[':hover']={
        backgroundColor:'pink',
        color:'black'

      }

      btnClass.push(classes.Red);
    }

    const assignedClasses=[];
    if(this.state.persons.length<=2)
    {
      assignedClasses.push(classes.red);

    }

    if(this.state.persons.length<=1)
    {
      assignedClasses.push(classes.bold);
    }
   // 

   return(
    <div className={classes.App}>
    <h1>hello this is my first react app</h1>
    <p className={assignedClasses.join(' ')}>this is really working</p>
  <button className={btnClass.join(' ')} onClick={this.togglePersonsHandler}>toggle person</button> 
    {persons}
    </div>
  
   );
  // return (
  //   //<StyleRoot>
  //   <div className="App">
  //     <h1>hello this is my first react app</h1>
  //     <p className={classes.join(' ')}>this is really working</p>
  //    <button 
  //     //style={style}
  //     onClick={this.togglePersonsHandler}>Switch button
      
  //     //</button>
  //     {/* {
  //       this.state.showPersons===true?
  //     <div>
  //     <Person 
  //     name={this.state.persons[0].name}
  //      age={this.state.persons[0].age}>my hobbies is crafting</Person>

  //     <Person name={this.state.persons[1].name}
  //      age={this.state.persons[1].age}
  //      changed={this.nameChangedhandler}>my hobbies is crafting</Person>
  //      </div>:null
  // } */}

  //   {persons}
  //   </div>
  //   //</StyleRoot>
  // );
   }
}

export default App;
