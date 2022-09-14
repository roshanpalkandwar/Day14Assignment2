namespace Day14Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chooes number\n1.Ability to create a Stack of");
            int opt=Convert.ToInt32(Console.ReadLine());   
            
            switch(opt)
            {
                case 1:
                    StackPushOperation stack1 = new StackPushOperation();
                    stack1.Push(70);
                    stack1.Push(30);
                    stack1.Push(56);
                    stack1.Display();
                    break;
            }
        }
    }
}