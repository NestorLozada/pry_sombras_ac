using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntercambioEsenas : MonoBehaviour
{
   public void cargaresenaPrincipal(){
       SceneManager.LoadScene("HouseScene");
   }
   public void Salir(){
       Application.Quit();
    }
}
