using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sortie : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
          rb.AddForce(transform.forward*10000 * Time.deltaTime);
        
    }
}
