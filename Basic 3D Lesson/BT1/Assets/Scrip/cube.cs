using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public GameObject cube1;
    public float mouseX;
    public float mouseY;
    public float mouseZ;
    public static cube instance;


    void Awake()
    {
        MakeInstance();
    }

    void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000) && hit.collider.tag == "cube")
            {
                Debug.DrawLine(ray.origin, hit.point);

            }
            else
            {
                mouseX = hit.point.x;
                mouseY = hit.point.y;
                mouseZ = hit.point.z+0.5f;

            }    
                
        }

    }
    
}
