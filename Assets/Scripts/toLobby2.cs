using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLobby2 : MonoBehaviour
{
    // Start is called before the first frame update
    public string Lobby2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Lobby2);
        }
    }
}
