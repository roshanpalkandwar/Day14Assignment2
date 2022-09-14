namespace Day14Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chooes number\n1.Ability to create a Stack of\n2.Ability to peak and pop\n3.Ability to create a Queue\n4.Ability to dequeue from the beginning");
            int opt=Convert.ToInt32(Console.ReadLine());   
            
            switch(opt)
            {
                case 1:
                    StackPeekPopOperation stack1 = new StackPeekPopOperation();
                    stack1.Push(70);
                    stack1.Push(30);
                    stack1.Push(56);
                    stack1.Display();
                    break;
               case 2:
                    StackPeekPopOperation  stack2 = new StackPeekPopOperation();
                    stack2.Push(70);
                    stack2.Push(30);
                    stack2.Push(56);

                    stack2.IsEmpty();

                    stack2.Display();
                    break;
                case 3:
                    QueueEnqueueOperation queue1 = new QueueEnqueueOperation();
                    queue1.Enqueue(56);
                    queue1.Enqueue(30);
                    queue1.Enqueue(70);
                    queue1.Display();
                    break;
                    case 4:
                    QueueDequeueOperation queue2 = new QueueDequeueOperation();
                    queue2.Enqueue(56);
                    queue2.Enqueue(30);
                    queue2.Enqueue(70);
                    queue2.IsEmpty();
                    queue2.Display();
                    break;
            }
        }
    }
}