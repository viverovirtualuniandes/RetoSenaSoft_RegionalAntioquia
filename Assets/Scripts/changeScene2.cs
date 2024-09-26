using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene2 : MonoBehaviour
{
    // Start is called before the first frame update
    public string Nivel2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(Nivel2);
        }
    }
}
