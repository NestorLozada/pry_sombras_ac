using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundControl : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource source;
    //public AudioClip footstep;

    void Update (){
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) ){
            source.enabled = true; 
        }
        else
        source.enabled = false;
    }

}
