using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoColision : MonoBehaviour
{
    public AudioSource audioSource;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag== "Untagged")
        {
            audioSource.Play();
        }
    }

}
