using System;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class Solution {

    public static Node insert(Node head,int data)
    {
        // creates a new Node (pass data as the Node constructor argument)
        Node node = new Node(data);
        
        if (head == null)
        {
            head = node;
        }
        else
        {
            Node tail = head;

            while (tail.next != null)
            {
                tail = tail.next;
            }
            
            // inserts the new Node at the tail (when next == null)
            tail.next = node;
        }

        // returns the reference to the head Node
        return head;
    }

	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
