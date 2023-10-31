using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    public float rotationSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationY = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
        float rotationX = Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;

        transform.Rotate(-rotationY, 0, 0);
        transform.Rotate(0,rotationX, 0);
    }
}
