using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;                     //���ӿ��� �� Ȱ��ȭ�� �ؽ�Ʈ ���� ������Ʈ
    public Text timeText;                               //���� �ð��� ǥ���� �ؽ�Ʈ ������Ʈ
    public Text recordText;                             //�ְ� ����� ǥ���� �ؽ�Ʈ ������Ʈ

    private float surviveTime;                          //���� �ð�
    private bool isGameover;                            //���ӿ��� ����

    public AudioSource endAudioPlayer;

    // Start is called before the first frame update
    void Start()
    {
        surviveTime = 0;                                //���� �ð��� ���ӿ��� ���� �ʱ�ȭ
        isGameover = false;

        endAudioPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)                                // ���ӿ����� �ƴ� ����
        {
            surviveTime += Time.deltaTime;              // ���� �ð� ����
            timeText.text = "Time;" + (int)surviveTime;  // ������ ���� �ð��� timeText �ؽ�Ʈ ������Ʈ�� �̿��� ǥ��
        }
        else
        {
            gameoverText.SetActive(true);               

            if (Input.GetKey(KeyCode.R))                // ���ӿ��� ���¿��� R Ű�� ���� ���
            {
                SceneManager.LoadScene("SampleScene");  // SampleleScene ���� �ε�
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;                              // ���� ���¸� ���ӿ��� ���·� ��ȯ
        gameoverText.SetActive(true);                   // ���� ���� �ؽ�Ʈ ���� ������Ʈ�� Ȱ��ȭ

        float bestTime = PlayerPrefs.GetFloat("BestTime");                //BestTime Ű�� ����� ���������� �ְ� �÷� ��������  

        if (surviveTime > bestTime)                     //���������� �ְ� ��Ϻ��� ���� ���� �ð��� �� ũ�ٸ�
        {
            bestTime = surviveTime;                     //�ְ� ��� ���� ���� ���� �ð� ������ ����
            PlayerPrefs.SetFloat("BestTime", bestTime); //����� �ְ� ����� BestTime Ű�� ����
        }

        recordText.text = "Best Time : " + (int)bestTime;   //BestTime ����

        endAudioPlayer.Play();

    }
}
