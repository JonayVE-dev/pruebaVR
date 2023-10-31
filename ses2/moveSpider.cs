using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public spiderA_event notifier;
    Vector3 bedPos;
    // Start is called before the first frame update
    void Start()
    {
        notifier.OnSpiderA_event += MoveToBed;
        bedPos = GameObject.Find("bed").transform.position + Vector3.up * 0.5f;
    }


    void MoveToBed() {
        transform.position = bedPos;
    }

}
