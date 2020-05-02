import React from 'react';
//import Radium from 'radium';
import styled from 'styled-components';
import classes from './Person.module.css';

// const StyledDiv=styled.div`
//      width:60%;
//     margin:16px auto;
//     border:1px solid blue;
//     padding: 16px;
//     text-align: center;

//     @media (min-width:500px){
//         width:'250px'
//     }
// `;
const person=(props)=>
{

    // const style={
    //     '@media (min-width:500px)':{
    //         width:'450px'
    //     }
    // };
return (
    
    //<div className='Person' style={style}>
    <div className={classes.Person}>
    <p onClick={props.click}>Hi i m {props.name} and i m {props.age} years old</p>
    <p>{props.children}</p>
    <input type="text" onChange={props.changed}></input>
    </div>
    //</div>
    );

// return 
// <p>I'm{props.name} and I am {props.age} years old!</p>
}

//export default Radium(person);

export default person;