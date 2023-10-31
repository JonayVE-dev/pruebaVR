using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chair_listener : MonoBehaviour
{
    public bed_event notifier;
    bool isJumping = false;
    float jumpForce = 1000;
    bool canJump = false;
    // Start is called before the first frame update
    void Start()
    {
        notifier.OnTouchBed += startJump;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0.5 && canJump)
        {
            isJumping = false;
        }
        jump();
    }

    void startJump() {
        Debug.Log("Start jumping");
        canJump = true;
    }

    void jump() {
        if (!isJumping && canJump)
        {
            isJumping = true;
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce * Time.deltaTime);
        }
    }
}
