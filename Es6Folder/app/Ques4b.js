// Filter unique array members using Set
function combine4_9()
{
    const array=[1,2,3,4,5,2,3,4];
    const uniquearray=new Set(array);
    const store=[...uniquearray];
    console.log(store);
}

console.log("Question4b\n\n");
combine4_9();

export default combine4_9;