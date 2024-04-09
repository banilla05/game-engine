using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidBody;   // �÷��̾� ������Ʈ�� �ִ� RigidBody ������Ʈ�� �����ϱ� ���� ����
    public float speed = 8f;    // �̵� �ӵ� ��ġ ���� �����ϴ� ����

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3 (xSpeed, 0f,zSpeed);
        playerRigidBody.velocity = newVelocity;
    }

       
       // if (Input.GetKey(KeyCode.UpArrow))
       // {
       //     playerRigidBody.AddForce(0, 0, speed);
       // }
       // if (Input.GetKey(KeyCode.DownArrow))
       // {
       //     playerRigidBody.AddForce(0, 0, -speed);
       // }
       // if (Input.GetKey(KeyCode.RightArrow))
       // {
       //    playerRigidBody.AddForce(speed, 0, 0);
       // }
       // if (Input.GetKey(KeyCode.LeftArrow))
       // {
       //     playerRigidBody.AddForce(-speed, 0, 0);
       // }       */

    

    public void Die()   // �÷��̾� ĳ���Ͱ� ����� ȣ��ǰ� �̺κ� ������ ó����.
    {
        gameObject.SetActive(false);
    }
}
