using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class ButtonHandler : MonoBehaviour, IVirtualButtonEventHandler {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < vbs.Length; i++)
        {
            vbs[i].RegisterEventHandler(this);
        }
	}

    // Update is called once per frame
    void Update()
    {
		
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("bouton appuyé");
        rb.isKinematic = false;
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("bouton relaché");
    }
}
