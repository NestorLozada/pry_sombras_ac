using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Piece : MonoBehaviour
{
    [SerializeField] private OpenIntereact linkedPuzzelManager;
    [SerializeField] private Transform correctPiece;
    private XRSocketInteractor socket;
    // Start is called before the first frame update
    private void Awake() => GetComponent<XRSocketInteractor>();

    // Update is called once per frame
    private void OnEnable() {
        socket.selectEntered.AddListener(ObjectSnapped);
        socket.selectEntered.AddListener(ObjectRemoved);
    }
    private void OnDisable() {
        socket.selectEntered.RemoveListener(ObjectSnapped);
        socket.selectEntered.RemoveListener(ObjectRemoved);
    }

    private void ObjectRemoved(SelectEnterEventArgs arg0)
    {
        var snappedObjectName = arg0.interactableObject;
        if (snappedObjectName.transform.name == correctPiece.name){
            linkedPuzzelManager.CompletTask();
        }
    }

    private void ObjectSnapped(SelectEnterEventArgs arg0)
    {
        var snappedObjectName = arg0.interactableObject;
        if (snappedObjectName.transform.name == correctPiece.name){
            linkedPuzzelManager.PiceRemove();
        }
    }
}
