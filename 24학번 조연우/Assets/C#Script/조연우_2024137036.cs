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

        Debug.Log("�ȳ��ϼ���"[0]);
        Debug.Log("�ȳ��ϼ���"[1]);
        Debug.Log("�ȳ��ϼ���"[2]);
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
        //���� �ڷ��� ��ȯ�� ���� ������ �ս� ��
        Long longNumber = 2147483647L + 2147483647L;
        int intNumber = (int) LongNumber;
        Debug.Log(intNumber);

        //���� �ڷ��� ��ȯ�� ���� ������ �ս� �߻����� �ʴ� ��
        long longNumber2 = 52273;
        int intNumber2 = (int)LongNumber2;
        Debug.Log(intNumber2);
    }

    void Start()
    {
        //long �ڷ����� int �ڷ������� ��ȯ�մϴ�.
        long longNumber = 2147483647L + 2147483647L;
        int longToint = (int)longNumber;
        Debug.Log(longToint);

        //double �ڷ����� int �ڷ������� ��ȯ�մϴ�.
        doubl doubleNumber = 52.27310332;
        int doubleToInt = (int)doubleNumber;
        Debug.Log(doubleToInt);
    }

    void Start()
    {
        //int �ڷ����� ���ڸ� �����մϴ�.
        int intNumber = 2147483647;

        //int �ڷ����� long �ڷ������� �ڵ� ��ȯ �մϴ�.
        long intToLong = intNumber;
        Debug.Log(intToLong);

        //int �ڷ����� double �ڷ������� �ڵ���ȯ �մϴ�.
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
