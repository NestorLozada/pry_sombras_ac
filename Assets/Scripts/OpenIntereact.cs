using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenIntereact : MonoBehaviour
{
    [SerializeField] private int Numbretasks;
    private int current_task= 0;
    [Header("Read the newspaper")]
    public UnityEvent onPuzzel; 
    // Start is called before the first frame update
    public void CompletTask() {
        current_task ++;
        ChekTast();
    }
    public void ChekTast(){
        if (current_task >= Numbretasks) {
            onPuzzel.Invoke();
        }
    }
    public void PiceRemove(){
        current_task --;
    }

}

