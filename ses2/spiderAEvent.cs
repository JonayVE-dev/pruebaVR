using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderA_event : MonoBehaviour
{
    public delegate void SpiderA_event();
    public event SpiderA_event OnSpiderA_event;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPointerEnter()
    {
        OnSpiderA_event();
    }

}
