class Stack {
    constructor() {
      this.list = new LinkedList();
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
      
      if(this.count === 1)
       {
        // If first node, 
        // point tail to it as well
        this.tail = this.head;
      }
    }
    
    push(data) {
      this.list.addFirst(data);
    }
    removeFirst()
     {
      if(this.count > 0) 
      {
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
    
    pop() {
      if(!this.list.length) {
        return;
      };
      
      let val = this.list.head.data;
      this.list.removeFirst();
      
      return val;
    }
    
    peek() {
      if(!this.list.head) { return; }
      return this.list.head.data;
    }
    
    get length() {
      return this.list.length;
    } 
  }