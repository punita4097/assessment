function removeDuplicate(arr)
{
    

    var finalArr=[];
    var count=0;

    for(var i=0;i<arr.length;i++)
    {
        for(var j=i+1;j<=arr.length;j++)
        {
            if(arr[i]==arr[j])
            {
                count++;
            }
        }

        if(count=0)
        {
            finalArr.push(arr[i]);
        }
        count=0;
    }
    console.log(finalArr);

}
var arr=[5,3,8,9,2,3,8];
removeDuplicate(arr);

export default removeDuplicate;