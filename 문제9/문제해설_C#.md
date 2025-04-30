---

# 📚 문제 요약

- 문자열 `str`이 주어졌을 때
- **한 글자씩 세로로 출력**하는 프로그램을 작성하자.

---

## ✅ 예시

**입력:**
```
abcde
```

**출력:**
```
a  
b  
c  
d  
e
```

---

# 🧠 C# 초보자 접근 포인트

| 개념 | 설명 |
|------|------|
| `Console.ReadLine()` | 문자열 입력받기 |
| `string` 타입 | C#에서 문자열 자료형 |
| `foreach` 또는 `for` | 문자열의 각 문자 순회 |
| `Console.WriteLine()` | 줄바꿈 포함 출력 |

---

# ✅ 전체 C# 코드

```csharp
using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine(); // 문자열 입력받기

        foreach (char c in input)
        {
            Console.WriteLine(c); // 한 글자씩 출력
        }
    }
}
```

---

## 📌 코드 설명

```csharp
string input = Console.ReadLine();
```
- 사용자로부터 문자열 한 줄을 입력받아 `input`에 저장한다.

```csharp
foreach (char c in input)
```
- 문자열은 문자들의 집합이므로 `foreach`로 하나씩 꺼낼 수 있다.

```csharp
Console.WriteLine(c);
```
- 각 문자를 줄마다 출력한다.

---

# 💡 보너스: `for`문으로 푸는 방법도 있어

```csharp
string input = Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    Console.WriteLine(input[i]);
}
```

---

# 📂 GitHub 정리 예시

```
beginner-csharp/
├── 문자열_돌리기/
│   ├── Program.cs
│   └── README.md
```

### README.md 예시

```md
## 🔄 문자열 돌리기 (C#)

문자열이 주어졌을 때, 각 문자를 한 줄씩 출력하는 문제입니다.

### 예시 입력
```
abcde
```

### 예시 출력
```
a
b
c
d
e
```

### 주요 문법
- 문자열 입력: `Console.ReadLine()`
- 문자열 순회: `foreach (char c in input)` 또는 `for` 반복문
- 출력: `Console.WriteLine(c)`

### 코드
```csharp
using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        foreach (char c in input)
        {
            Console.WriteLine(c);
        }
    }
}
```
```

---
