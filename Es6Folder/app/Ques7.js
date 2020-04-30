// Write a program to implement a class having static functions



class Question7
{
    static multiply(a,b)
    {
        return a*b;
    }
    static add(a,b)
    {
        return (a+b);
    }
}
console.log("Question7\n\n");
let a=Question7.multiply(5,7);
console.log(a);
let b=Question7.add(5,9);
console.log(b);

export default Question7