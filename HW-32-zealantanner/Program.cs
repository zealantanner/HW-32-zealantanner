using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<string> stringlist = new List<string>();
        int search;
        stringlist.Add("public");
        stringlist.Add("protected");
        stringlist.Add("private");

        stringlist.Sort();

        List<string> stringlist2 = new List<string>()
        {"private", "public", "protected", "other", "word", "protected internal"};

        foreach (string accessModifier in stringlist2)
        {
            search = stringlist.BinarySearch(accessModifier);
            if (search < 0)
            {
                stringlist.Insert(~search, accessModifier);
            }
        }
        Console.WriteLine();
        foreach (string accessModifier in stringlist)
        {
            Console.WriteLine(accessModifier);
        }

        Console.WriteLine();

        List<int> intlist = new List<int>()
        {
            1,2,3,4
        };

        List<int> Evenresults = intlist.FindAll(Even);
        Console.Write("Even: ");
        foreach (int number in Evenresults)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        List<int> Oddresults = intlist.FindAll(Odd);
        Console.Write("Odd: ");
        foreach (int number in Oddresults)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
    public static bool Even(int value) => (value % 2) == 0;
    public static bool Odd(int value) => (value % 2) != 0;
}
