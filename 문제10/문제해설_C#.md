---

# 🧠 문제 요약

- 입력: `공백`으로 구분된 두 문자열 (예: `"apple pen"`)
- 출력: 두 문자열을 **붙여서** 출력 (예: `"applepen"`)

---

## ✅ 초보자가 접근하는 방법

---

### 1단계: 문자열 입력받기  
C#에서는 `Console.ReadLine()`을 사용해서 한 줄 전체를 입력받을 수 있어.

```csharp
string input = Console.ReadLine(); // 예: "apple pen"
```

---

### 2단계: 입력 문자열을 공백 기준으로 나누기  
공백으로 나누고 싶을 땐 `Split()` 함수를 사용해.  
문자열 배열로 결과가 나와!

```csharp
string[] parts = input.Split(' '); // parts[0] = "apple", parts[1] = "pen"
```

---

### 3단계: 문자열 이어붙이기  
C#에서는 문자열끼리 `+` 연산자로 붙일 수 있어.

```csharp
string result = parts[0] + parts[1]; // "applepen"
```

---

### 4단계: 결과 출력

```csharp
Console.WriteLine(result);
```

---

# ✅ 전체 코드 (C#)

```csharp
using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();         // 전체 입력 받기
        string[] parts = input.Split(' ');         // 공백으로 분리
        string result = parts[0] + parts[1];       // 문자열 합치기
        Console.WriteLine(result);                 // 출력
    }
}
```

---

## 🧪 실행 예시

**입력:**
```
apple pen
```

**출력:**
```
applepen
```

---

# 💡 초보자 팁 정리

| 개념 | 설명 |
|------|------|
| `Console.ReadLine()` | 한 줄 입력받기 |
| `string.Split(' ')` | 공백 기준으로 문자열 나누기 |
| `+` | 문자열 이어붙이기 |
| `Console.WriteLine()` | 문자열 출력 |

---

# 📂 GitHub 정리 예시

```
beginner-csharp/
├── 문자열_붙여서_출력하기/
│   ├── Program.cs
│   └── README.md
```

---

### README.md 예시

```md
## 🔗 문자열 붙여서 출력하기 (C#)

### 문제 설명
두 개의 문자열을 공백으로 입력받아, 공백 없이 이어붙여 출력하는 문제입니다.

### 입력 예시
```
apple pen
```

### 출력 예시
```
applepen
```

### 사용 문법
- 문자열 입력: `Console.ReadLine()`
- 문자열 나누기: `string.Split(' ')`
- 문자열 붙이기: `+`
- 출력: `Console.WriteLine()`

### 코드
```csharp
using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        string result = parts[0] + parts[1];
        Console.WriteLine(result);
    }
}
```
```

---
