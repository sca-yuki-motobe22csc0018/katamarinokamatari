using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Katamari;
    float cx=0;
    float cy=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Katamari.transform.position + new Vector3(0, 4+cx, -6+cy);
        if (KatamariController.count > 10)
        {
            KatamariController.count=0;
            cx+=2;
            cy-=3;
        }
    }
}
