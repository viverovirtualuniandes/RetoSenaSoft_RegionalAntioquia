using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class floreroExit : MonoBehaviour
{

    void start()
    {
        originalPosition = transform.position;
    }

    public Transform ObjectToMove;

    public Vector3 newPosition;

    public Vector3 originalPosition;

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Florero"))
        {
            ObjectToMove.position = newPosition;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Florero"))
        {
            ObjectToMove.position = originalPosition;
        }
    }



}