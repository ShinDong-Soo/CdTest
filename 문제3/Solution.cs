using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        int a = Int32.Parse(input[1]);
        
        for (i > 0;, i <= a,i++;)
        {    
            Console.WriteLine($"{s1}{s1 * i}")
        }
    }
}


문제점:

문자열을 반복할 수 있는 함수로 활용해야 한다는 생각을 하지 못함.

