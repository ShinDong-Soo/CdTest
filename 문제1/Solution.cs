class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (a > 0 && b < 10)
        {
            Console.WriteLine(a + b);
        }
        return;
    }
}

-----------------------------------------------------

System.FormatException: 'The input string '1 2' was not in a correct format.'

------------------------------------------------------
  
풀지 못한 이유: 

> 입력을 받았으나, 주어진 조건을 잘못 해석했음.
