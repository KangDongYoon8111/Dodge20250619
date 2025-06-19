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
        //수평축과 수직축을 float형 변수에 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //저장된 변수를 실제속도로 변환
        //float xSpeed = xInput * speed;
        //float zSpeed = zInput * speed;
        float xSpeed = xInput * speed;
        float zSpeed =zInput * speed;

     
        //Vector3로 변환
        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        //리지드바디 속도에 할당
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
