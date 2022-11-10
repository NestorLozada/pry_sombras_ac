using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    public float distancia= 3f;
   

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; 
        if ( Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out hit, distancia))
        {
            if( hit.collider.tag == "Door")
            {
                if(Input.GetKeyDown(KeyCode.E) )
                {
                    hit.collider.transform.GetComponent<SystemDoor>().ChangeDoorState();
                }
            }
            if( hit.collider.tag == "CuadroTag")
            {   

              if(Input.GetKeyDown(KeyCode.C)) {
                     hit.collider.GetComponent<SystemCuadro>().cambio();  
                }           
                    
            }else{
                return; 
            }
            
        }
       
        
    }
}
