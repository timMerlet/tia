using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afficherAide : MonoBehaviour {

    public Transform t;
    private bool textAffiche = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void afficherText()
    {
        if(textAffiche){
            t.localScale += new Vector3(0.14F, 0, 1);
            textAffiche = false;
        }
        else{
            t.localScale += new Vector3(0.14F, 2, 1);
            textAffiche = true;
        }
    }
}
