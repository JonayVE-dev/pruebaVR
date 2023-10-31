using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderC : MonoBehaviour
{
    bool isJumping = false;
    float jumpForce = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        if (transform.position.y < 0.5)
        {
            isJumping = false;
        }
    }

    void Jump()
    {
        if (!isJumping)
        {
            isJumping = true;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce * Time.deltaTime);
        }
    }
}
