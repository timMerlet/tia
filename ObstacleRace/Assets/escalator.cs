using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escalator : MonoBehaviour {

    public float force = 1000.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        rb.AddForce(Vector3.left * force * Time.deltaTime);
    }
}
