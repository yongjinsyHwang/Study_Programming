using UnityEngine;

public class ControlStatements : MonoBehaviour
{
    public int age = 40;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //=======================IF 조건문 [기초]=======================

        // 만약에 논리식(조건)이라면, 결과 출력
        if (age <= 29)
        {
            Debug.Log("영크크");
        }
        else if(age <= 39)
        {
            Debug.Log("늙크크");
        }    
        // 해당 규격 외
        else if(age <= 49)
        {
            Debug.Log("놀리지도 못하겠네...");
        }
        else
        {
            Debug.Log("안녕하세요 ㅎㅎ.");
        }

        //=======================Switch 조건문=======================
        string myName = "짜바리 조직원";

        switch (myName)
        {
            case "간사이의 용":
                Debug.Log("고다 류지");
                break;
            case "도지마의 용":
                Debug.Log("키류 카즈마");
                break;
            case "도지마의 광견":
                Debug.Log("마지마 고로");
                break;
            default:
                Debug.Log("너는 어느 단체 소속이냐..?");
                break;
        }
        //=======================연습 문제=======================
        // 1. 숫자를 변수에 넣고, 그 수가 양수인지, 음수인지, 0인지 출력하는 프로그램
        int var = 0;
        if(var < 0)
        {
            Debug.Log("음수입니다.");
        }
        else if(var > 0)
        {
            Debug.Log("양수입니다.");
        }
        else
        {
            Debug.Log("0입니다.");
        }

        // 2. 특정 연도를 변수에 넣고, 그 년도가 윤년인지 아닌지 계산해서 출력하는 프로그램
        float year = 2024f;
        if (year % 4 == 0)
        {
            if(year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Debug.Log("윤년");
                }
                else if(year % 400 > 0)
                {
                    Debug.Log("평년");
                }
            }
            else if (year % 100 > 0)
            {
                Debug.Log("윤년");
            }
        }
        else if(year % 4 > 0)
        {
            Debug.Log("평년");
        }
        //else if (year % 100 == 0)
        //{
        //    Debug.Log("평년");
        //}
        //else if (year % 400 == 0)
        //{
        //    Debug.Log("윤년");
        //}

        // 3. 문자열 변수에 연산기호 중 하나를 넣고 숫자 변수에 두 개의 수를 넣는다. 연산 기호에 따라 두 수를 계산해서 결과를 출력하는 프로그램
        int var2 = 10;
        int var3 = 20;
        string op = "+";
        if(op == "+")
            Debug.Log(var2 + var3);
        else if (op == "-")
            Debug.Log(var2 - var3);
        else if (op == "/")
            Debug.Log(var2 / var3);
        else if (op == "*")
            Debug.Log(var2 * var3);

        switch(op)
        {
            case "+":
            Debug.Log(var2 + var3);
                break;
            case "-":
                Debug.Log(var2 - var3);
                break;
            case "/":
                Debug.Log(var2 / var3);
                break;
            case "*":
                Debug.Log(var2 * var3);
                break;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
