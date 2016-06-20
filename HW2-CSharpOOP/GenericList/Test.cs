using System;

namespace GenericList
{
    class Test
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int>(3);
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Remove(1);
            //Console.WriteLine(list[2]);
        }
    }
}