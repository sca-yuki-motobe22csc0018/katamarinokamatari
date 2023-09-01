using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatamariController : MonoBehaviour
{
    [SerializeField] float speed =5;
    [SerializeField] float firstspeed = 300;
    public static float count=0;
    private Rigidbody rb;
    Collider collider;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        speed /=10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(0, 0, speed * firstspeed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(0, 0, -speed * firstspeed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(-speed * firstspeed, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(speed*firstspeed, 0, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag=="Object")
        {
            collision.collider.isTrigger = true;
            collision.transform.parent = this.transform;
            this.transform.localScale+=new Vector3(0.1f,0.1f,0.1f);
            count+=1;
        }
    }
}
