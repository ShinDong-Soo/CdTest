public class Example
{
    public static void Main()
    {

        char s = Console.ReadKey().KeyChar;
        
        if (char.IsLower(s))
        {
            Console.WriteLine(char.ToUpper(s));
        }
        else if (char.IsUpper(s))
        {
            Console.WriteLine(char.ToLower(s));
        }      
    }
}


**문제점**

*  `Console.ReadKey()`는 **단 하나의 문자**만 읽어옴. 
    따라서 입력 문자열이 여러 글자로 이루어져 있어도 첫 번째 글자만 처리하고 나머지는 무시.
  
*  문제에서 요구하는 것은 **문자열 전체**를 대소문자로 변환하여 출력하는 것.
