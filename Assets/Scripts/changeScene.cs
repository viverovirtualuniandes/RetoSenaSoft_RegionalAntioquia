using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{

    public string Nivel1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Player"))
        {
            SceneManager.LoadScene(Nivel1);
        }
    }

    // Start is called before the first frame update
   
}
