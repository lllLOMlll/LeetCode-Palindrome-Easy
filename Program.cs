using System;

class Program
{
    public bool IsPalindrome(int x)
    {     
        string numberToString = x.ToString();
        int numberLength = numberToString.Length;

        for (int i = 0; i < numberLength/2; i++)
        {
            if (numberToString[i] != numberToString[numberLength- i - 1])
            {
                return false;
            }
        }

        return true;  
    }

    static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("121: " + p.IsPalindrome(121));  
        Console.WriteLine("4548: " + p.IsPalindrome(4548));
        
    }
}
