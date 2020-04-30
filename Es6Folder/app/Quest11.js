// Implement a singly linked list in es6 and implement addFirst() addLast(), length(), getFirst(), getLast(). (without using array)

class LinkedList 
{
    constructor() 
    {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }
    get length() 
    {
        return this.count;
    }

    addLast(data) 
    {
    // Create a new Node
        const node = {
        data: data,
        next: null
        }
        if(this.count === 0) {
        // If this is the first Node, assign it to head
        this.head = node;
        } 
        else {
        // If not the first node, link it to the last node
        this.tail.next = node;
        }
        this.tail = node;
        this.count++;
    }
    
    addFirst(data) 
    {
    // Create a new Node
        const node = {
        data: data,
        next: null
        }

    // Save the first Node
        const temp = this.head;
    // Point head to the new Node
        this.head = node;
    // Add the rest of node behind the new first Node
        this.head.next = temp;
        this.count++;
        if(this.count === 1) {
        // If first node,
    // point tail to it as well
        this.tail = this.head;
        }
    }
    removeFirst()
     {
        if(this.count > 0) {
    // The head should point to the second element
        this.head = this.head.next;
        this.count--;
        
        if(this.count === 0)
         {
        // If list empty, set tail to null
        this.tail = null;
        }
        }
    }
    
    getFirst()
    {
        let getFirstNode=this.head;
        if(!this.head)
        {
            console.log("Linked list is empty");
        }
        else
        {
            console.log("The first element of linked list is " +getFirstNode.data);
        }
    }
    
    getLast()
    {
        let getLastNode=this.tail;
        
        if(!this.head)
        {
            console.log("Linked list is empty");
        }
        else
        {
            console.log("The last element of linked list is " +getLastNode.data);
        }
    }

    listLength()
    {
        let counter = 0;
        let node = this.head;
    
        if(!this.head)
        {
            console.log("Linked list is empty");
        }
        
        else
        {
            while(node.next!=null)
            {
            counter++;
            node=node.next;
            }
            counter+=1;
            console.log("The length of list is "+counter);
        }
    }
    printList()
    {
        let curr = this.head;
        let out = [];
        while(curr !== null)
        {
            if(curr.next === null)
            {
                out.push(curr.data);
            }
            else
            {
                out.push(curr.data);
                out.push("->")
            }
            curr = curr.next;
        }
    var r= out.join("");
   // console.log(`${r}`);

    }
}
    console.log("Question 11\n\n");
    var obj = new LinkedList();
    obj.addLast(2);
    obj.addLast(19);
    obj.addFirst(1);
    obj.addFirst(100);
    obj.addLast(4);
    obj.addFirst(45);
    obj.getFirst();
    obj.getLast();
    obj.listLength();
    
    export default LinkedList;