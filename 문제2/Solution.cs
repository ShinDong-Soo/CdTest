public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        Console.WriteLine($"a = ", {a});
        Console.WriteLine($"b = ", {b});
    }


/Solution0.cs(15,38): error CS1525: Unexpected symbol `{'
/Solution0.cs(15,40): error CS1525: Unexpected symbol `a'
/Solution0.cs(15,42): error CS1002: ; expected
/Solution0.cs(15,43): error CS1519: Unexpected symbol `)' in class, struct, or interface member declaration
/Solution0.cs(16,26): error CS1519: Unexpected symbol `(' in class, struct, or interface member declaration
/Solution0.cs(16,37): error CS1519: Unexpected symbol `}' in class, struct, or interface member declaration
/Solution0.cs(16,40): error CS9010: Primary constructor body is not allowed
/Solution0.cs(16,42): error CS1002: ; expected
/Solution0.cs(16,43): error CS1519: Unexpected symbol `)' in class, struct, or interface member declaration
/Solution0.cs(18,0): error CS1525: Unexpected symbol `}'

## 문제점:
Split() 메서드를 사용하여 공백을 기준으로 문자열을 나눠 배열에 저장하였지만,
출력할 때 " " 범위를 잘못 선정하였음.
