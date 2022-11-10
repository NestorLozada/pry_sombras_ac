using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linterna : MonoBehaviour
{
    [SerializeField]
    GameObject Flashligh_Light; 
    private bool isOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Flashligh_Light.gameObject.SetActive ( false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            if(isOn ==false)
            {
                Flashligh_Light.gameObject.SetActive(true);
                isOn = true;
            }
            else
            {
                Flashligh_Light.gameObject.SetActive(false);
                isOn = false;
            }
        }    
        
    }
}
