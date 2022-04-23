using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float horizontalSpeed = 2.0f;
    float rotatey=0;
    private void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            if (Mathf.Abs(rotatey+=h) < 50)
            {
                transform.Rotate(0, -h, 0);
                rotatey += h;
                Debug.Log(rotatey);

            }
               

        }
         
    }
}
