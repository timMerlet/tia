using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aspirateur : MonoBehaviour {

    public float force = 1000.0f;
    public Transform leT;

	// Use this for initialization
	void Start () {
        leT = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        //float vx= leT.pos
        Vector3 dir = transform.position - rb.position;
        dir.y = 0;
        rb.AddForce(dir* force * Time.deltaTime);
       rb.drag = 2;
        Vector3 pulse= dir;
        //pulse.z=0;
        //pulse.x=0;
        //pulse.y =- pulse.y;
       /*if (dir.x < 10)
       {
           rb.AddForce(transform.up * force *100* Time.deltaTime);
       }*/
    }
}
