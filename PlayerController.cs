using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    private float moveSpeed = 5.0f;
    private float jumpForce = 5.0f;
    private float rotationSpeed = 5.0f;
    private int jumpCount = 0;

    private void Move()
    {
        float X = Input.GetAxis("Horizontal");
        float Y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Y, 0f, X) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount <= 0)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpCount++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("background"))
        {
            jumpCount = 0;
        }
    }

    private void Turn()
    {
        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * mouseX * rotationSpeed);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        Turn();
    }
}
