using System;

namespace KR_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var temp = new SetOfStacks<int>(3);
            temp.Push(23);
            temp.Push(23);
            temp.Push(23);
            temp.Push(23);
            temp.Push(23);
            temp.Push(23);
            temp.Pop();
        }
    }
}
