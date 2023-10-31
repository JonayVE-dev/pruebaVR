using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{
    public float maxTime = 5f;
    float timer;
    bool isPowerActive;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0f;
        isPowerActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isPowerActive)
        {
            timer += Time.deltaTime;
            if(timer > maxTime)
            {
                gameObject.SetActive(false);
                isPowerActive = false;
            }
        }
    }

    void OnPointerEnter()
    {
        isPowerActive = true;
    }

    void OnPointerExit()
    {
        isPowerActive = false;
    }
}
