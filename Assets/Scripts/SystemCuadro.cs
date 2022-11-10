using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SystemCuadro : MonoBehaviour
{
    public bool estaEncendido=false;
    public GameObject imgtxt;
   public void cambio(){
       estaEncendido=!estaEncendido;
       imgtxt.SetActive(estaEncendido);
   }
   
   
    
    // void Update()
    // {
    //    if (estaEncendido){
    //     imgtxt.SetActive(true);
      
    // }else{
    //     imgtxt.SetActive(false);
    // }
    // }
}
