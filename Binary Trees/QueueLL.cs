namespace Binary_Trees
{
    public class Node 
    {
        public TreeNode value;
        public Node next;
        public Node(TreeNode value)
        {
            this.value = value;
            this.next = null;
        }
    }
    public class QueueLL
    {
        public Node front;
        public Node rear;
        public QueueLL()
        {
            this.front = null;
            this.rear = null;
        }
        public void Enqueue(TreeNode val)
        {
            var newNode = new Node(val);
            if (this.front == null) {
                this.front = newNode;
                this.rear = newNode;
                // System.Console.WriteLine("Added element to an empty queue");
                return;
            }
            this.rear.next = newNode;
            this.rear = newNode;
            // System.Console.WriteLine("Added element to the queue");
        }

        public TreeNode Dequeue()
        {
            if (this.front == null) {
                throw new System.Exception("This is an empty queue to begin with");
            }
            var result = this.front;
            var newFront = this.front.next;
            this.front = newFront;
            return result.value;
        }
        public bool IsEmpty()
        {
            if (this.front == null) {
                return true;
            }
            return false;
        }
    }
}