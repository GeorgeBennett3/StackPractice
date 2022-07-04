namespace StackPractice
{
    internal class Program
    {
        static void Main()
        {
            Stack<string> myStack = new Stack<string>(4);
            myStack.Push("This is first in.");
            myStack.Push("This is 2nd.");
            myStack.Push("So its first out.");
            myStack.Push("This is last in.");
            string[] myArr = myStack.ToArray();
            Console.WriteLine("This is a stack turned into an array");
            foreach (string str in myArr)
            {
                Console.Write(str + " ");
            }
            Console.ReadLine();
        }
    }
}