using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;

    private void Start()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody>();
      
    }
    private void Update()
    {
        //������� �������� float�� ������ ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //����� ������ �����ӵ��� ��ȯ
        //float xSpeed = xInput * speed;
        //float zSpeed = zInput * speed;
        float xSpeed = xInput * speed;
        float zSpeed =zInput * speed;

     
        //Vector3�� ��ȯ
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //������ٵ� �ӵ��� �Ҵ�
        playerRigidbody.linearVelocity = newVelocity;


        /*AddForce Method
        if (Input.GetKey(KeyCode.UpArrow) == true)
        {
            playerRigidbody.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow) == true)
        {
            playerRigidbody.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) == true)
        {
            playerRigidbody.AddForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow) == true)
        {
            playerRigidbody.AddForce(-speed, 0, 0);
        }*/
    }


}
