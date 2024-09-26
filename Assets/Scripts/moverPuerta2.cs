using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moverPuerta2 : MonoBehaviour
{

   
    public Transform ObjectToMove;

    public Vector3 newPosition;

    public Vector3 originalPosition;

    private void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ObjectToMove.position = newPosition;
        }
    }



}
