using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovie : MonoBehaviour
{

  
    // Update is called once per frame
    void Update()
    {
        if(cube.instance != null)
        {
            // transform.position.x = cube.instance.mouseX;
            transform.position = new Vector3(cube.instance.mouseX, transform.position.y, cube.instance.mouseZ);
        }
        
    }
}
