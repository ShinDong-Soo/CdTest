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


** 문제점 **

** 1. `Console.Clear()`의 위치 **
*   `Console.Clear()`는 콘솔 화면을 지우는 역할. 
     이 코드를 `Console.ReadLine()` 전에 위치시키면 사용자가 입력한 내용이 지워지기 때문에 입력값을 받을 수 없게 됨. 
    `Console.Clear()`는 필요한 경우 입력 *후*에 사용.

** 2. 문자열 보간 **
*   C#에서 문자열 보간을 사용할 때, 변수를 중괄호 `{}`로 묶어야 함. 
    현재 코드에서는 `${a}`와 `${b}`가 올바르지 않은 위치에 있음.

** 3. 불필요한 공백 **
*   `Console.WriteLine($"a = ", {a});`에서 `a = ` 뒤에 불필요한 공백이 있음.
