using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderB : MonoBehaviour
{
    Vector3 Point1;
    Vector3 Point2;

    bool moveTo = true;
    // Start is called before the first frame update
    void Start()
    {
        // point1 y 2 son puntos random entre -5 y 5 en x y z
        Point1 = new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2));
        Point2 = new Vector3(Random.Range(-2, 2), 0, Random.Range(-2, 2));
    }

    // Update is called once per frame
    void Update()
    {
        move(moveTo);
    }
    
    void move(bool direction) {
        if(direction) {
            moveToPoint1();
        } else {
            moveToPoint2();
        }
    }

    void moveToPoint1() {
        Vector3 spiderPosition = gameObject.transform.position;
        Vector3 direction = Point1 - spiderPosition;

        gameObject.transform.Translate(direction.normalized * Time.deltaTime);

        if (Vector3.Distance(spiderPosition, Point1) < 1) {
            moveTo = false;
        }

        
    }

    void moveToPoint2() {
        Vector3 spiderPosition = gameObject.transform.position;
        Vector3 direction = Point2 - spiderPosition;

        gameObject.transform.Translate(direction.normalized * Time.deltaTime);

        if (Vector3.Distance(spiderPosition, Point2) < 1) {
            moveTo = true;
        }
    }
}
