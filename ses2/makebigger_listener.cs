using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makebigger : MonoBehaviour
{
    public spiderA_event notifier;
    // Start is called before the first frame update
    void Start()
    {
        notifier.OnSpiderA_event += MakeBigger;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeBigger() {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }

}
