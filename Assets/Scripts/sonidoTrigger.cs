using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Guitarra"))
        {
            audioSource.Play();
        }
    }

}
