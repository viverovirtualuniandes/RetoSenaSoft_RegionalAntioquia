using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toLobby : MonoBehaviour
{
    // Start is called before the first frame update
    public string Lobby;

    public void ToLobby(string Lobby)
    {

        SceneManager.LoadScene(Lobby);


    }


}
