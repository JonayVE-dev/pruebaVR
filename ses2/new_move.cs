using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_player : MonoBehaviour
{
    public float speed = 10f;
    public float rotationSpeed = 100f;
    public float jumpForce = 100f;
    private Rigidbody rb;

    private bool isGrounded = true;


    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");

        transform.Rotate(0, rotation * rotationSpeed * Time.deltaTime, 0);
        rb.AddForce(transform.forward * translation * speed);

        if(transform.position.y < 0.5)
        {
            isGrounded = true;
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
        }
    }
}
