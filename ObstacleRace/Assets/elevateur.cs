using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class elevateur : MonoBehaviour {

    private float force = 1000.0f;
    public Transform leT;
	// Use this for initialization
    void Start()
    {
        leT = GetComponent<Transform>();
    }
	
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        float incr=  rb.position.y + 0.5f;
        Vector3 dir = transform.position - rb.position;
         if (Math.Abs(dir.x) < 0.1 && Math.Abs(dir.z) <0.1)
   {
        //rb.position = new Vector3(rb.position.x, incr , rb.position.z);
       //rb.AddForce(transform.up * force *100* Time.deltaTime);
       rb.AddForce(transform.up * force * 15 * Time.deltaTime);
   } 

        //rb.AddForce(transform.up * force * 50 * Time.deltaTime);
    }
}
