using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVE : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    public KeyCode keyCode;
    // Start is called before the first frame update

    Rigidbody body;
    
    void Start()
    
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalForce = Input.GetAxis("Horizontal") * speed;
        float verticalForce = Input.GetAxis("Vertical") * speed;
        body.AddForce(new Vector3(horizontalForce, 0, verticalForce));

        if(Input.GetKeyDown(keyCode)) {
            Jump();
        }
    }

    void Jump() {
        body.AddForce(Vector3.up * jumpForce);
    }
}
