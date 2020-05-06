//Write a program to implement inheritance upto 3 classes.The Class must  public variables and static functions.

class Person
{
    static print1()
    {
        console.log("static block of the I class");
    }

    constructor(firstName,lastName)
    {
        this.firstName=firstName;
        this.lastName=lastName;
    }
    fullname()
    {
           var store=`${this.firstName} ${this.lastName}`;
           return store;
    }
    
}
class Car extends Person
{
    static print2()
    {
        console.log("static block of the II class");
    }

    constructor(firstName,lastName,modal)
    {
        super(firstName,lastName);
        this.modal=modal;

    }
    
}
class features extends Car
{
    static print3()
    {
        console.log("static block of the III class");
    }

    constructor(firstName,lastName,modal,color)
    {
        super(firstName,lastName,modal);
        this.color=color;;
    }

    
}

console.log("Question6\n\n");
var obj=new features('Punita','Yadav','Mercedes-Benz EQC','grey');

console.log('Name:'+obj.fullname());
console.log('Modal:'+obj.modal);
console.log('Color:'+obj.color);

features.print1();
features.print2();
features.print3();


export default Person;