using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour
{
    // Update is called once per frame
    private Vector3 start;
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100) && hit.collider.tag == "Quad")
            {
               
                float angel = Vector3.SignedAngle(start, hit.point,transform.position)*150;
                start = hit.point;
                transform.Rotate(transform.position, angel);
                Debug.Log(angel);
               
            }

        }
       
    }

    void rotate()
    {


    }
}
