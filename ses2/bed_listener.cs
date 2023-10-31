using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed_listener : MonoBehaviour
{
    public bed_event notifier;
    bool isLeft = false;
    bool startMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        notifier.OnTouchBed += startMove;
    }

    // Update is called once per frame
    void Update()
    {
        if (startMoving) {
            if (isLeft) {
                MoveRight();
            } else {
                MoveLeft();
            }
        }
    }

    void startMove() {
        Debug.Log("Start moving");  
        startMoving = true;
    }

    void MoveLeft() {
        if (isLeft) {
            return;
        }
        isLeft = true;
        transform.Translate(Vector3.forward * 0.5f);
    }

    void MoveRight() {
        if (!isLeft) {
            return;
        }
        isLeft = false;
        transform.Translate(-Vector3.forward * 0.5f);
    }
}
