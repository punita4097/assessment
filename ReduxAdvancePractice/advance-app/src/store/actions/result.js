import * as actionTypes from './actionsTypes';


export const saveResult=(res)=>{
    return{
        type:actionTypes.STORE_RESULT,
        result:res
    };
}

export const storedResult=(res)=>{
    return (dispatch,getState)=>{
        setTimeout(()=>{
            const olcCounter=getState().ctr1.counter;
            console.log(olcCounter);
            dispatch(saveResult(res));
        },2000);
    }
}


export const deleteResult =(resElId)=>{
    return{
        type:actionTypes.DELETE_RESULT,
        val:resElId
    };
}