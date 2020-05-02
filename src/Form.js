import React, { Component } from 'react';
import './Form.css';
class Form extends React.Component {
  render() {

    return (
      <div className="Form">
        <h3>Enter fruit with Quantity</h3>  
        <form onSubmit={this.props.handleFormSubmit}>
          
          
          <input className="Input" type="text" name="name"
          placeholder="fruit of any choice with quantity (format should be like Mango-20"
            onChange={this.props.handleInputChange}
            value={this.props.newName}
             />
          
          <br/>
          <button className="btn_submit" type="submit" value="Submit">Submit</button>
        </form>
      </div>
    );
  }
}

export default Form;

