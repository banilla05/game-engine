using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;                              //������ ź���� ���� ������
    public float spawnRateMin = 0.5f;                            //�ּ� ���� �ֱ�
    public float spawnRateMax = 3f;                             //�ִ� ���� �ֱ�

    private Transform target;                                   //�߻��� ���
    private float spawnRate;                                    //���� �ֱ�
    private float TimeAfterSpawn;                               //�ֱ� ���� �������� ���� �ð�

    public AudioSource audioPlayer;

    // Start is called before the first frame update
    void Start()
    {
       TimeAfterSpawn = 0f;                                   //�ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        spawnRate = Random.Range(spawnRateMin, spawnRateMax); //ź�� ���� ������ spawnRateMax ���̿��� ���� ����
        target = FindObjectOfType<PlayerController>().transform; //PlayerController ������Ʈ�� ���� ���� ������Ʈ�� ã�� ���� ������� ����

        audioPlayer = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {   // Ÿ�ӿ����ͽ��p �ð� ���� (Update������ �귯�� �ð��� ���� �ջ�)
        TimeAfterSpawn += Time.deltaTime;            //TimeAfterSpawn ����

        if (TimeAfterSpawn >= spawnRate)             //�ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        {
            TimeAfterSpawn = 0f;                     //������ �ð��� ����

            //BulletPrefab�� ��������
            //transform.position ��ġ�� transform.rotation ȸ������ ����
            GameObject bullet
                = Instantiate(bulletPrefab, transform.position, transform.rotation);
             //������ bullet ���� ������Ʈ�� ���� ������ target�� ���ϵ��� ȸ������
             bullet.transform.LookAt(target);

            //��ź ������ ��ź �߻��� ����
            audioPlayer.Play();

        }
    }
}
