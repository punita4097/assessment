import React,{Component} from 'react';
import Person from '../components/Person/Person';
import AddPerson from '../components/AddPerson/AddPerson';
import {connect} from 'react-redux';
import * as actionTypes from '../store/actions';

class Persons extends Component{
/*
    state={
        persons:[]
    }

    personAddedHandler=()=>{
        const newPerson={
            id:Math.random(),
            name:'Punita',
            age:Math.floor(Math.random()*40)
        }
        this.setState((prevState)=>{
            return{persons:prevState.persons.concat(newPerson)}
        });
    }

    personDeletedHandler = (personId) => {
        this.setState( ( prevState ) => {
            return { persons: prevState.persons.filter(person => person.id !== personId)}
        } );
    }
*/

render () {
    return (
        <div>
            <AddPerson personAdded={this.props.onAddedPerson} />
            {this.props.prs.map(person => (
                <Person 
                    key={person.id}
                    name={person.name} 
                    age={person.age} 
                    clicked={() => this.props.onRemovedPerson(person.id)}/>
            ))}
        </div>
    );
}
}

const mapStateToProps = state => {
return {
    prs: state.persons
};
};

const mapDispatchToProps = dispatch => {
return {
    onAddedPerson: (name, age) => dispatch({type: actionTypes.ADD_PERSON, personData: {name: name, age: age}}),
    onRemovedPerson: (id) => dispatch({type: actionTypes.REMOVE_PERSON, personId: id})
};
};

export default connect(mapStateToProps,mapDispatchToProps)(Persons);