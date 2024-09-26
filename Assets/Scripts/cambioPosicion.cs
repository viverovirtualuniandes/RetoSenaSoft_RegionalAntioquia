using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class cambioPosicion : MonoBehaviour
{

   
    public Transform ObjectToMove;

    public Vector3 newPosition;

   

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ObjectToMove.position = newPosition;
        }
    }
   


}