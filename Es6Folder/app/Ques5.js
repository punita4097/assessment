//Find the possible combinations of a string and store them in a MAP

function permutations()
{
      var letters = 'abc';
      var combo = [];
      var temp= "";
      var count=0;
      let finalMap = new Map();

      var letterLen = Math.pow(2, letters.length);

          for (var i = 0; i < letterLen ; i++)
          {
              temp= "";
              for (var j=0;j<letters.length;j++) 
              {
                  if ((i & Math.pow(2,j)))
                  { 
                      temp += letters[j]+ " "
                  }
              }
              if (temp !== "")
               {
                 //var result= combo.push(temp);
                 
                var a= finalMap.set(`Key_${ count++}`,temp);
                
                 combo.push(temp);
                 
              }
              console.log(a);
          }
          
          console.log(`${combo}`);
         

    }

    console.log("Question5\n\n");
permutations();

export default permutations;