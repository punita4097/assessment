import React, { Component } from 'react';

class Form extends React.Component {
  render() {

    return (
      <div id="Form">
        <h3>Add fruit with Quantity</h3>  
        <form onSubmit={this.props.handleFormSubmit}>
          <label htmlFor="name">
          Fruit Name:
          <input id="name" type="text" name="name"
            onChange={this.props.handleInputChange}
            value={this.props.newName}
             />
          </label>
          {/* <label htmlFor="quantity">
          Quantity:
          <input id="quantity" value={this.props.newQuantity} 
            type="text" name="quantity"
            onChange={this.props.handleInputChange} />
          </label> */}
          <button type="submit" value="Submit">Submit</button>
        </form>
      </div>
    );
  }
}

export default Form;