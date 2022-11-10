using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
   public Image imagenVida;

    public float vidaActual=100;

    public float vidaMaxima=100;
    
    void Update()
    {
        /*if(vidaActual > 50)
        {
            vidaActual = vidaActual - 1;
        }
        imagenVida.fillAmount = vidaActual /vidaMaxima;
        */
        if( Input.GetKeyDown (KeyCode.R))
        {
            Healing (10f);
        }

         if( Input.GetKeyDown (KeyCode.T))
        {
            Damage (10f);
        }
        
    }

    public void Damage (float damgePoints){
        vidaActual = damgePoints;
        imagenVida.fillAmount = vidaActual/100;
    }

    public void Healing (float healPoints)
    {
        vidaActual += healPoints;
        vidaActual =   Mathf.Clamp ( vidaActual,0,100);  
        imagenVida.fillAmount = vidaActual / 100; 

    }
}
