//Given this array: `[3,62,234,7,23,74,23,76,92]`, Using arrow function, create an array of the numbers greater than `70`
function find()
{
let arr=[3,62,234,7,23,74,23,76,92];
let greaterlist=arr.filter((n)=>n>70);


console.log(greaterlist);
}

console.log("Question1\n\n");
find();
export default find;
