using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class GenericListTest
{
    static void Main(string[] args)
    {
        GenericList<int> someList = new GenericList<int>();

        someList.Add(1);
        someList.Add(2);
        someList.Add(111);

        Console.WriteLine("Full list : {0}", someList);
        
        Console.WriteLine("Find 2 : {0}", someList.Find(2,1));
        Console.WriteLine("Find 333 : {0}", someList.Find(333));

        someList.RemoveAt(1);

        Console.WriteLine("Full list after remove position 1: {0}", someList);

        someList.AddAt(1, 4);

        Console.WriteLine("After add 4 at position 1 : {0}", someList);

        someList.Clear();

        Console.WriteLine("After clear : {0}", someList);
    }
}

