import React, { Component } from 'react';
import './Tables.css';
class Table extends React.Component {

  render() {
    const items = this.props.items;
    return (
      <div id="Table">
        <table>
          <tbody>
            <tr>
              <th>Name</th>
              <th>Quantity</th>
            </tr>
            {items.map(item => {
              return (
                <tr key={item.id}>
                  <td>{item.name}</td>
                  <td>{item.quantity}</td>
                  <td><button className="btn_delete" onClick={()=>this.props.handleDeleteChange(item.id)}>Delete</button></td>
                </tr>
              );
            })}
          </tbody>
        </table>
      </div>
    );
  }
}

export default Table;
