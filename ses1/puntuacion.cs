using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        //Debug.Log("Soy " + gameObject.name + " y acabo de detectar una colisión con " + collision.gameObject.name);
        if(other.gameObject.CompareTag("spider")) {
            points += 10;
            Debug.Log("Puntuación: " + points);
        }
    }
}
