using System;

public class Example
{
    public static void Main()
    {
        string[] s
            
        s = Console.ReadLine().Split('');
        
        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s((1));
        
        Console.WriteLine($"{a} + {b} = {a + b}");
    }
}

                            
## **🚨 문제 1: `stirng` → `string` 오타**
```csharp
stirng[] s
```
- **오타 발생**: `stirng` → `string`으로 수정해야 합니다.
- **C#에서는 `string`이 기본 자료형**이며, `stirng`은 존재하지 않는 타입이므로 **컴파일 오류가 발생합니다.**

✅ **수정 코드**
```csharp
string[] s;
```

---

## **🚨 문제 2: `Split('')` 사용 오류**
```csharp
s = Console.ReadLine().Split('');
```
- `Split('')`는 **잘못된 문법**입니다.  
- `Split()` 함수는 **문자 또는 문자열을 기준으로 나누는 메서드**이며, **빈 문자열(`''`)을 사용하면 오류가 발생**합니다.  
- **공백(`' '`)을 기준으로 숫자를 분리해야 함.**

✅ **수정 코드**
```csharp
s = Console.ReadLine().Split(' '); // 공백을 기준으로 나누기
```

---

## **🚨 문제 3: `Int32.Parse(s(1))` → `Int32.Parse(s[1])`**
```csharp
int a = Int32.Parse(s[0]);
int b = Int32.Parse(s(1));  // ❌ 잘못된 문법
```
- C#에서 배열 요소를 접근할 때는 **대괄호(`[]`)를 사용**해야 합니다.
- **소괄호(`()`)는 메서드 호출용이므로, `s(1)`은 문법 오류 발생**.

✅ **수정 코드**
```csharp
int a = Int32.Parse(s[0]);
int b = Int32.Parse(s[1]); // ✅ 대괄호 사용
```

---

## **🚨 문제 4: `Console.WriteLine`에서 `+` 기호 중복**
```csharp
Console.WriteLine($"{a} + {b} + {a + b}");
```
- `+` 기호가 **세 번 등장**하면서, `a + b + a + b`로 연산되어 **출력이 잘못됨**.
- **올바른 연산 순서를 유지하도록 수정해야 함.**

✅ **수정 코드**
```csharp
Console.WriteLine($"{a} + {b} = {a + b}");
```
                            
