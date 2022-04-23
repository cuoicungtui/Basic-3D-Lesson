using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube1 : MonoBehaviour
{
    public Rigidbody rg;
    public GameObject cube2;
    public GameObject cube3;
    // Update is called once per frame
    private void Start()
    {
        rg = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, 1000))
            {
               switch(hit.collider.tag)
               {
                    case "cube1":
                        Debug.Log("1");
                        break;
                    case "cube2":
                        Debug.Log("2");
                        Vector3 Vt = cube2.transform.position -  transform.position ;
                        // rg.MovePosition(transform.position + -Vt * Time.deltaTime * 3f);
                        rg.AddForce(Vt * 3f);
                        //transform.position = transform.position + Vt * Time.deltaTime * 3f;
                        //rg.velocity = Vt;
                        break;
                    case "cube3":
                        Debug.Log("3");
                        Vector3 Vt2 = cube3.transform.position - transform.position;
                        // rg.MovePosition(transform.position + -Vt * Time.deltaTime * 3f);
                        //rg.AddForce(Vt2 * 3f);
                        transform.position = transform.position + Vt2 * Time.deltaTime * 3f;
                        break;
               }    


            }

        }
        else
        {
            rg.velocity = new Vector3(0, 0, 0);
        }


    }
}
