using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderA : MonoBehaviour
{
    GameObject chair;
    GameObject table;

    bool moveTo = true;
    // Start is called before the first frame update
    void Start()
    {
        chair = GameObject.Find("sillaA");
        table = GameObject.Find("mesaA");
    }

    // Update is called once per frame
    void Update()
    {
        move(moveTo);
    }
    
    void move(bool direction) {
        if(direction) {
            moveToTable();
        } else {
            moveToChair();
        }
    }

    void moveToTable() {
        Vector3 tablePosition = table.transform.position;
        Vector3 spiderPosition = gameObject.transform.position;
        Vector3 direction = tablePosition - spiderPosition;

        gameObject.transform.Translate(direction.normalized * Time.deltaTime);

        if (Vector3.Distance(spiderPosition, tablePosition) < 1) {
            moveTo = false;
        }

        
    }

    void moveToChair() {
        Vector3 chairPosition = chair.transform.position;
        Vector3 spiderPosition = gameObject.transform.position;
        Vector3 direction = chairPosition - spiderPosition;

        gameObject.transform.Translate(direction.normalized * Time.deltaTime);

        if (Vector3.Distance(spiderPosition, chairPosition) < 1) {
            moveTo = true;
        }
    }
}
