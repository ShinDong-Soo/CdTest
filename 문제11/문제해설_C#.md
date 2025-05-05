---

## ✅ 문제 요약

* 문자열 `my_string`이 있고,
* `overwrite_string`을 `my_string`의 **s번째 위치부터 겹쳐 써야 해요**.
* 그러면 새로운 문자열을 만들어서 **결과로 반환**하면 됩니다.

---

## 📌 예제 1 분석

```txt
my_string       = "He11oWor1d"
overwrite_str   = "lloWorl"
s               = 2
```

### 인덱스 기준 위치 보기:

| 인덱스 | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 |
| --- | - | - | - | - | - | - | - | - | - | - | -- |
| 문자  | H | e | 1 | 1 | o | W | o | r | 1 | d |    |

### 겹쳐쓰기를 할 부분:

* `s = 2`부터
* `overwrite_string = "lloWorl"` (7글자) 만큼 덮어쓰기
* 즉, `my_string[2] ~ my_string[8]` 까지 바뀜

### 결과:

```
"HelloWorld"
```

---

## ✅ 문제 해결 단계 (초보자용 풀이 흐름)

1. **my\_string을 3부분으로 나누기**

   * 앞부분 (`0 ~ s-1`)
   * 중간부분 (덮어쓸 부분, → overwrite\_string으로 바꿀 부분)
   * 뒷부분 (`s + overwrite_string.Length`부터 끝까지)

2. **이 3부분을 연결하기 (앞 + 덮어쓸 부분 + 뒷부분)**

---

## ✅ 예시 코드 (C#)

```csharp
public class Solution {
    public string solution(string my_string, string overwrite_string, int s) {
        string front = my_string.Substring(0, s);
        string back = my_string.Substring(s + overwrite_string.Length);
        return front + overwrite_string + back;
    }
}
```

---

## ✅ 코드 설명

```csharp
string front = my_string.Substring(0, s);
```

* s 전까지 앞부분을 잘라냄

```csharp
string back = my_string.Substring(s + overwrite_string.Length);
```

* 덮어쓴 이후 뒷부분을 잘라냄

```csharp
return front + overwrite_string + back;
```

* 3개를 이어 붙여서 새로운 문자열 반환

---

## ✅ 초보자가 주의할 점

| 개념                | 설명                                |
| ----------------- | --------------------------------- |
| `Substring(a, b)` | 문자열의 a번 인덱스부터 b개 문자 추출            |
| 문자열은 **불변**       | C# 문자열은 수정할 수 없고, 새로운 문자열로 만들어야 함 |
| 문자열 이어붙이기         | `+` 연산으로 앞 + 중간 + 뒤 이어서 새 문자열 생성  |

---

## ✅ 연습용 문제 (비슷한 구조)

* `"abcdefg"`에서 `"XYZ"`를 인덱스 3부터 넣으면?
  → `"abcXYZg"`

---
