using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework : MonoBehaviour
{
    // Start is called before the first frame update\
    /*
    void Start()
    {
        Debug.Log(message + "!");
        Debug.Log(message[0]);
        Debug.Log(message[1]);
        Debug.Log(message[2]);

        Debug.Log("안녕하세요"[0]);
        Debug.Log("안녕하세요"[1]);
        Debug.Log("안녕하세요"[2]);
    }

    void Start()
    {
        bool one = 10 < 0;
        bool other = 20 >100;

        Debug.Log(one);
        Debug.Log(other);
    }

    void Start()
    {
        int output = 0;
        output += 52;
        output += 273;
        output += 103;

        Debug.Log(output);
    }

    void Start()
    {
        string output = "hello ";
        output += "wprld";
        output += "!!";
        Debug.Log(output);
    }

    void Start()
    {
        int number = 10;
        number++;
        Debug.Log(number);
        number--;
        Debug.Log(number);
    }

    void Start()
    {
        int number = 10;
        Debug.Log(number);
        Debug.Log(number++);
        Debug.Log(number--);
        Debug.Log(number);
    }

    void Start()
    {
        int number = 10;
        Debug.Log(number);
        Debug.Log(++number);
        Debug.Log(--number);
        Debug.Log(number);
    }

    void Start()
    {
        //강제 자료혀 반환에 따른 데이터 손실 예
        Long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int) LongNumber;
        Debug.Log(intNumber);

        //강제 자료형 변환에 따른 데이터 손실 발생하지 않는 예
        long longNumber2 = 52273;
        int intNumber2 = (int)LongNumber2;
        Debug.Log(intNumber2);
    }

    void Start()
    {
        //long 자료형을 int 자료형으로 변환합니다.
        long longNumber = 2147483647L + 2147483647L;
        int longToint = (int)longNumber;
        Debug.Log(longToint);

        //double 자료형을 int 자료형으로 변환합니다.
        doubl doubleNumber = 52.27310332;
        int doubleToInt = (int)doubleNumber;
        Debug.Log(doubleToInt);
    }

    void Start()
    {
        //int 자료형의 숫자를 생성합니다.
        int intNumber = 2147483647;

        //int 자료형을 long 자료형으로 자동 변환 합니다.
        long intToLong = intNumber;
        Debug.Log(intToLong);

        //int 자료형을 double 자료형으로 자동변환 합니다.
        double intToDouble = intNumber;
        Debug.Log(intToDouble);
    }

    void Start()
    {
        Debug.Log(int.Parse("52"));
        Debug.Log(int.Parse("273"));
        Debug.Log(int.Parse("52.273"));
        Debug.Log(int.Parse("103.32"));

        Debug.Log(int.Parse("52").GetType());
        Debug.Log(int.Parse("273").GetType());
        Debug.Log(int.Parse("52.273").GetType());
        Debug.Log(int.Parse("103.32").GetType());
    }

    void Start()
    {
        Debug.Log((52).ToString());
        Debug.Log((52.273).ToString());
        Debug.Log(('a').ToString());
        Debug.Log((true).ToString());
        Debug.Log((false).ToString());

        Debug.Log((52).ToString().GetType());
        Debug.Log((52.273).ToString());
        Debug.Log(('a').ToString());
        Debug.Log((true).ToString());
        Debug.Log((false).ToString());
    }

    void Start()
    {
        double number = 52.273103;
        Debug.Log(number.ToString("0.0");
        Debug.Log(number.ToString("0.00");
        Debug.Log(number.ToString("0.000");
        Debug.Log(number.ToString("0.0000");
    }

    void Start()
    {
        Debug.Log(52 + 273);
        Debug.Log("52" + 273);
        Debug.Log(52 + "273");
        Debug.Log('52' + "273");
    }
    /*
}
