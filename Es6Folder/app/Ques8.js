//Import a module containing the constants and method for calculating area of circle, rectangle, cylinder.
class Area
{
    static Circle(r)
    {
        const pi=3.14;
        let a=pi*r*r;
        console.log(`Area of circle ${a}`);

    }

    static Reactangle(l,b)
    {
        let a=l*b;
        console.log(`area of Rectangle ${a}`);

    }

    static Cylinder(r,h)
    {
        const pi=3.14;
        let a=2*pi*r*h + 2*pi*r*r;
        console.log(`area of cylinder ${a}`);
    }
}

//call the static function
console.log("question8\n\n");
Area.Circle(5);
Area.Reactangle(5,7);
Area.Cylinder(2,3);

export default Area;