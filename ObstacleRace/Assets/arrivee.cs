using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrivee : MonoBehaviour {

    public TextMesh leText;
    private float time;

	// Use this for initialization
	void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
	}

    void OnCollisionEnter(Collision col)
    {
        leText.text = "félicitation vous venez de gagner en "+time +" s";
    }

}
