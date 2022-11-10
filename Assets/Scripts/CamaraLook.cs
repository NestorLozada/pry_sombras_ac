using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLook : MonoBehaviour
{
    
    public float mouseSen = 1000.0f;
    public Transform playerbody;
    float xrotation = 0.0f;

    void Start()
    {
        
    }

  
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSen * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSen * Time.deltaTime;
        xrotation -= mouseY;
        xrotation = Mathf.Clamp(xrotation,-90f,90);
        transform.localRotation=Quaternion.Euler(xrotation,0f,0f);
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
