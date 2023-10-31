using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntuacion : MonoBehaviour
{
    int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) {
        //Debug.Log("Colisión detectada");
        if(other.gameObject.CompareTag("spider") && gameObject.transform.position.y > 0.1f) {
            points += 10;
            Debug.Log("Puntuación: " + points);
        }
    }
}
