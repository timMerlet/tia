using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class perdu : MonoBehaviour {

    public TextMesh leText;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision col)
    {
        leText.text = "pas de chance, retentez votre chance une prochaine fois ;)";
    }
}
