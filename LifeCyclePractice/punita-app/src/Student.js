import React, { Component } from 'react';
import Marks from './Marks';

class student extends Component{
    constructor(){
        super();
        this.state={
            roll:101
        }
    }

    ClickHandle=()=> {
        console.log("button clicked");
        this.setState({roll:this.state.roll+2});
    };

    componentWillUnmount()
  {
    console.log("Student-component will unmount will called");
  }
    render(){
        console.log("Student-rendered");
        return(
        <div>Hello {this.props.name}
        <Marks roll={this.state.roll}/>
        <button onClick={this.ClickHandle}>Change</button>
        </div>
        );
    }
}

export default student;