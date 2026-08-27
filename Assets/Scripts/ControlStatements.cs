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
        string myName = "간사이의 용";

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
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
