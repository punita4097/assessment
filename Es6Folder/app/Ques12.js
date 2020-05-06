//Implement Map and Set using Es6
class Question12
{
    //example of set
    Example_set()
    {
        let chars='asfhsudduhhufhkfjodfkkjhxvmvjkh';
        let chars_arr=chars.split("");
        let chars_set=new Set(chars_arr);
        console.log(chars_set);
    }
//example of map
    Example_map()
    {
        let numArr=[[1,'one'],[2,'two']];
        let valMap=new Map(numArr);
        for(let[key,value] of valMap.entries())
        {
            console.log(`${key} points to ${value}`);
        }

    }
}

let obj=new Question12();
console.log("Question12\n\n");
obj.Example_set();
obj.Example_map();

export default Question12;