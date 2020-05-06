//Implementation of stack (using linked list)

class NodeStack{
    constructor(item, next = null){
        this.item = item,
        this.next = next
    }
}

class StackUsingLinkedList
{
    constructor()
    {
        this.top = null;
    }
    //Insert operation on stack
        push(item)
        {
            let nodeStack=new NodeStack(item);
            if(this.top)
            {
                nodeStack.next=this.top;
                this.top=nodeStack;
            }
            else
            {
                this.top=nodeStack;
            }
        }
    //delete operation on stack
    pop() 
    {
        if( this.top ) 
        {
          let itemToPop = this.top
          this.top = this.top.next
          //return itemToPop.data
        } 
        else 
        {
         console.log("The stack is empty");
          return false;
        }
    }

    //return first element without deleting it
    peek()
     {
        if( this.top )
         {
            
            console.log('The topmost element is:'+this.top.item);
        } 
        else 
        {
            console.log("The stack is empty");
        }
    }

    //find length of stack
    length()
     {
        let current = this.top
        let counter = 0
        while( current ) 
        {
             counter++
            current = current.next
        }
        console.log('length is:'+counter);
    }


    //traverse the whle stack
    traverse() 
    {
        if(this.top)
        {
            var current = this.top; 
            var resultStack = current.item+" ,"; 
            while (current.next!=null) 
            { 
                current = current.next; 
                resultStack += current.item + ","; 
            } 
            
            
            console.log('The elements:'+ resultStack);
        }
        else{
            console.log("The stack is empty");   
        }

    }
}





//creating new instance of Stack
let st = new StackUsingLinkedList();   

console.log("Question13\n\n");
st.push(15);
st.push(25);
st.push(35);
st.traverse();
st.length();
st.peek();

export default StackUsingLinkedList; 
