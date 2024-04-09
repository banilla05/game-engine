using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 8f;                    //ź�� �̵� �ӷ�
    private Rigidbody bulletRigidbody;          //�̵��� ����� ������ٵ� ������Ʈ


    // Start is called before the first frame update
    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(Collider other)         //Ʈ���� �浹 �� �ڵ����� ����Ǵ� �ż���
    {
        if (other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();
            //���� ���� ������Ʈ���� playerController ������Ʈ ��������

            if (playerController != null)       //�������� ���� PlayerController ������Ʈ�� �������� �� �����ߴٸ�
            {
                playerController.Die();         //���� PlayerController ������Ʈ Die() �ż������
            }
        }
    }
}
