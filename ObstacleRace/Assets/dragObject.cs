using System.Collections;
using UnityEngine;

class dragObject : MonoBehaviour
{
    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    private bool dragging = false;
    private bool rotating = false;
    private float distance;


    void OnMouseEnter()
    {
        //renderer.material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        //renderer.material.color = originalColor;
    }

    void OnMouseDown()

    {
        if (Input.GetMouseButtonDown(0))
        {
            distance = Vector3.Distance(transform.position, Camera.main.transform.position);
            //Debug.Log('hello francis');
            dragging = true;
        }
        else if (Input.GetMouseButtonDown(2))
        {
            rotating = true;
        }

    }

    void OnMouseUp()
    {
        dragging = false;
        rotating = false;
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            transform.position = rayPoint;
            transform.Rotate(Vector3.up * Time.deltaTime * 70);
        }
        else if (rotating)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * 1000);
        }
    }
}