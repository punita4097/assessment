import React, { Component } from 'react';

class marks extends Component{
    constructor(props){
        super(props);
        this.state={
            mroll:this.props.roll
        };

    }

    static getDerivedStateFromProps(props,state){

            console.log("derived state from props of marks component is called");
            console.log(props,state);
            if(props.roll!==state.mroll)
            {
                return{mroll:props.roll};
            }
            return null;
    }

    shouldComponentUpdate(nextProps,nextState){
        if(this.state.mroll<107)
        {
            console.log("Mark-shouldComponentUpdate called");
            console.log(nextProps,nextState);
            return true;
        }
        console.log(nextProps,nextState);
        return false;
    }

    getSnapshotBeforeUpdate(prevProps,prevState){
        console.log('getSnapshotBeforeUpdate-is called');
        console.log(prevProps,prevState);
        return 45;
    }

    componentDidUpdate(prevProps,prevState,snapshot){

        console.log(" Component did update always used with getsnapshot update");

        console.log(prevProps,prevState,snapshot);

    }
    render(){
        console.log("marks-rendered");

        return(
            <div>
                <h1>{this.state.mroll}</h1>
            </div>

        );
    }
}

export default marks;