//Import a module for filtering unique elements in an array

function Question9()
{
    var arr = [100, 23, 45, 67, 45, 
        33, 34, 69, 100, 23]
           
var outputArray = []; 

 
var count = 0; 
var flag = false; 

for (var j = 0; j < arr.length; j++) 
{ 
    for (var k = 0; k < outputArray.length; k++) 
    { 
        if ( arr[j] == outputArray[k] )
         { 
            flag = true; 
        } 
    } 

    count++; 
    if (count == 1 && flag == false) 
    { 
        outputArray.push(arr[j]); 
    } 
    flag = false; 
    count = 0; 
} 
console.log(outputArray);
}
console.log('Question9\n\n');
//call the function
Question9();

export default Question9;
