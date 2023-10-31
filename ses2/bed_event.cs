using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bed_event : MonoBehaviour
{
    public delegate void TouchBed();
    public  event TouchBed OnTouchBed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        //use compareTag to check if the object is the bed_person
        if(collision.gameObject.CompareTag("bed_person")) {
                OnTouchBed();
        }
    }
}
