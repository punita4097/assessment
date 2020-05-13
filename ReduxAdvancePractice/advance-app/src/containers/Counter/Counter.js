import React, { Component } from 'react';
import {connect} from 'react-redux';
import CounterControl from '../../components/CounterControl/CounterControl';
import CounterOutput from '../../components/CounterOutput/CounterOutput';
import * as actionCreators from '../../store/actions/index';

class Counter extends Component {
    state = {
        counter: 0,
        results:[]
    }

    counterChangedHandler = ( action, value ) => {
        switch ( action ) {
            case 'inc':
                this.setState( ( prevState ) => { return { counter: prevState.counter + 1 } } )
                break;
            case 'dec':
                this.setState( ( prevState ) => { return { counter: prevState.counter - 1 } } )
                break;
            case 'add':
                this.setState( ( prevState ) => { return { counter: prevState.counter + value } } )
                break;
            case 'sub':
                this.setState( ( prevState ) => { return { counter: prevState.counter - value } } )
                break;
        }
    }

    render () {
        return (
            <div>
                <CounterOutput value={this.props.ctr} />
                <CounterControl label="Increment" clicked={this.props.onIncrementCounter} />
                <CounterControl label="Decrement" clicked={this.props.onDecrementCounter}  />
                <CounterControl label="Add " clicked={this.props.onAdd}  />
                <CounterControl label="Subtract " clicked={this.props.onSubtract}  />

                <hr/>
                <button onClick={()=>this.props.onStoreResult(this.props.ctr)}>Store Result</button>
                <ul>
                   {this.props.storedResults.map(strResult => (

                   <li key={strResult.id} onClick={()=>this.props.onDeleteResult(strResult.id)}>{strResult.value}</li>
                   ))} 
       
                </ul>

            </div>
        );
    }
}
const mapStateToProps=state=>{

    return{
        ctr:state.ctr1.counter,
        storedResults:state.res1.results
    };
};

const mapDispatchToProps = dispatch => {
    return {
        onIncrementCounter: () => dispatch(actionCreators.increment()),
        onDecrementCounter: () => dispatch(actionCreators.decrement()),
        onAdd: () => dispatch(actionCreators.add(10)),
        onSubtract: () => dispatch(actionCreators.subtract(8)),
        onStoreResult: (result) => dispatch(actionCreators.storedResult(result)),
        onDeleteResult: (id) => dispatch(actionCreators.deleteResult(id))

    };
};
export default connect(mapStateToProps, mapDispatchToProps)(Counter);