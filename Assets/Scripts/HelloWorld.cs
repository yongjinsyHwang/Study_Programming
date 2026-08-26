using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    //전역 변수
    int A;
    long B;
    float CA;
    float CB;
    bool D;
    string EA;
    string EB;
    void Start()
    {
        Debug.Log("세상아 반갑다는 뜻 ㅇㅇ");

        A = 2;
        B = 1000000000000;
        Debug.Log(A + B);
        Debug.Log(A * B);

        // float의 정밀도가 떨어지는지에 대한 실험
        CA = 12345678901234567;
        CB = 12345678900000000;
        Debug.Log((CA == CB).ToString());

        // boolean 응용
        D = (CA == CB);
        Debug.Log(D);

        EA = "이것은 문자형 변수를 출력한 것입니다.";
        EB = "그렇다고요...";
        Debug.Log(EA +" "+EB);
    }

    void Update()
    {
        
    }
}
