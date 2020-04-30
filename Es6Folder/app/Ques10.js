// Write a program to flatten a nested array to single level using arrow functions.
function flattenarray()
{
    var myArray = [[1, 2],[3, 4, 5], [6, 7, 8, 9]];
    var myNewArray = [];
        for (var i = 0; i < myArray.length; ++i) 
        {
            for (var j = 0; j < myArray[i].length; ++j)
             myNewArray.push(myArray[i][j]);
        }
    console.log(myNewArray);

}
console.log("Question10\n\n");
flattenarray();
 export default flattenarray;