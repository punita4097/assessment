import React from 'react';

const style={

    display:'inline-block',
    padding:'16px',
    margin:'16px',
    border:'1px solid blue',
    textAlig:'center'

};
const char=(props)=>
    {
        return(

            <div
                style={style}>
                {props.character}
            </div>
        );
    };

    export default char;