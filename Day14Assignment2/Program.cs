namespace Day14Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chooes number\n1.Ability to create a Stack of\n2.Ability to peak and pop");
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
            }
        }
    }
}