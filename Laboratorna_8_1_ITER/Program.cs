using System;

public class Program
{
    public static int Count(string s)
    {
        int count = 0;
        int index = 0;
        string searchString = "while";

        while ((index = s.IndexOf(searchString, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += searchString.Length;
        }

        return count;
    }

    public static string Change(string s)
    {
        int whileGroupsCount = Count(s);
        string result = "";

        int index1 = 0, index2 = 0;
        string searchString = "while";

        while ((index1 = s.IndexOf(searchString, index1, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            result += s.Substring(index2, index1 - index2) + "**";
            index2 = index1 + searchString.Length;
            index1 = index2;
        }

        result += s.Substring(index2);

        return result;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter string:");
        string str = Console.ReadLine();

        int whileGroupsCount = Count(str);
        Console.WriteLine($"The string contains {whileGroupsCount} occurrences of 'while'");

        string modifiedStr = Change(str);
        Console.WriteLine($"Modified string: {modifiedStr}");
    }
}