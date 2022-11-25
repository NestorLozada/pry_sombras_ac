using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDLE_FOR_GAME_OVER : MonoBehaviour
{
    private Animator anim;
    public AudioSource screamer;
    public AudioClip clip; 

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   
        
    }
}
