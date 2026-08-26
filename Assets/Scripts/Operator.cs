using UnityEngine;

public class Operator : MonoBehaviour
{
    int a;
    int b;
    
    int c;
    int d;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        a = 5;
        b = 3;
        //=======================산술 연산자=======================
        Debug.Log("a와 b의 덧셈 결과는 " + (a + b));
        Debug.Log("a와 b의 뺄셈 결과는 " + (a - b));
        Debug.Log("a와 b의 곱셈 결과는 " + (a * b));
        Debug.Log("a와 b의 나눗셈 몫 결과는 " + (a / b));
        Debug.Log("a와 b의 나눗셈 나머지 결과는 " + (a % b));

        // 값이 실수형일 경우, 몫 값이 실수값으로 출력한다.
        Debug.Log("a와 b의 나눗셈 몫 결과는 " + (5f / b));

        //f접미사를 사용하지 않을 경우, double 자료형으로 출력한다.
        Debug.Log("a와 b의 나눗셈 결과는 " + (5.0 / 2));
        Debug.Log("a와 b의 나눗셈 결과는 " + (5.0f / 2));

        // float 자료형은 f 접미사를 사용해야 한다.
        //c = 5.0;

        //=======================비교 연산자=======================
        // boolean 자료형으로 출력된다.
        Debug.Log(a < b);
        Debug.Log(a > b);
        Debug.Log(a <= b);
        Debug.Log(a >= b);

        // [a = b]의 의미는 대입, [a == b] 비교이다.
        Debug.Log(a == b);
        Debug.Log(a != b);

        //연산자 우선순위에 있어서, 비교 연산자는 사칙연산보다 하위이다.
        Debug.Log(a < b + c);

        //=======================논리 연산자=======================
        c = 4;
        d = 5;
        Debug.Log(!true);

        Debug.Log(a < b || c < d);
        Debug.Log(a < b && c < d);

        Debug.Log(!(a < b) && c < d);

        // !(NOT) 연산자는 다른 논리 연산자와 동일하게 참(true)과 거짓(false)로 결과가 출력되는 구조로 설명해야한다.
        // Debug.Log(!(a + b) > c && a+ c > b);

        //=======================대입 연산자=======================
        // 단순 대입 연산자
        a = b + c; // 7
        a = a + 2; // 9

        // 복합 대입 연산자
        a += 2; // 11
        a *= 2; // 22
        a -= 2; // 20
        a /= 2; // 10

        // 증감 연산자
        a++; // 21
        b++; // 4

        //=======================조건 연산자=======================
        // 삼항 연산자로, b가 c보다 코드만 1을 대입, 아니면 2를 대입한다.
        a = (b > c) ? 1 : 2;

        //===========================null==========================
        //"아무런 값도 참조하고 있지 않음"을 나타내는 C#의 특수한 값이며, 0과는 다르다.
        string txt;

        txt = "";
        txt = null;

        //========================null 병합========================
        string txt2 = "abc";
        
        // null이 아닐 경우 txt, null이 맞을 경우 txt2;
        string txt3 = txt ?? txt2;

        // true가 null, 그래서 false인 txt2를 선택한다.
        txt3 = null ?? txt2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
