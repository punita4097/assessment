import Question12 from "./Ques12";

class Question2
{
    // Select all the list items on the page and convert to array
  firstPart()
    {
        let finalArray=[];
        let listElements=document.getElementById("navbar").getElementsByTagName("li");
        for(let element of listElements)
        {
            finalArray.push(element.textContent)

        }
        console.log(`${finalArray}`);

    }

  // Filter for only the elements that contain the word 'Flexbox'
  secondPart()
   {
        let finalArray=[];
        let listElements = document.getElementById("navbar").getElementsByTagName("li");
        for(let element of listElements)
        {
            if(element.textContent.includes("Flexbox"))
            {
                finalArray.push(element.textContent)
            }
        }
        console.log(`${finalArray}`);
    }

    // map down to a list of time strings

    thirdPart()
    {
        let finalArray=[];
        let listElements = document.getElementById("navbar").getElementsByTagName("li");
        for(let element of listElements)
        {
            finalArray.push( element.attributes[0].value)

        }
        console.log(`${finalArray}`);

    }

    // map to an array of seconds
    fourthPart()
    {
        let secondsFinalArray=[];
        let finalArray=[];
        let listElements = document.getElementById("navbar").getElementsByTagName("li");
        for(let element of listElements)
        {
            finalArray.push( element.attributes[0].value)

        }
       
        
        finalArray.map(time => {
        const parts = (time.split(":")[0]) *60 + Number(time.split(":")[1])
        secondsFinalArray.push(parts)
        })

        console.log(`${secondsFinalArray}`);
    }

    // reduce to get total
    fifthPart()
    {
        let secondsFinalArray=[];
        let finalArray=[];
        let listElements = document.getElementById("navbar").getElementsByTagName("li");
        for(let element of listElements)
        {
            finalArray.push( element.attributes[0].value)

        }
       
        
        finalArray.map(time => {
        const parts = (time.split(":")[0]) *60 + Number(time.split(":")[1])
        secondsFinalArray.push(parts)
        })


        let TotalTime=secondsFinalArray.reduce((runningTotal, seconds) => runningTotal + seconds);

        console.log(`${TotalTime}`);
    } 
}


var obj=new Question2();
console.log("Question2\n\n");
obj.firstPart();
obj.secondPart();
obj.thirdPart();
obj.fourthPart();
obj.fifthPart();
export default Question2;