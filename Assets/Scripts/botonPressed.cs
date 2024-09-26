using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonPressed : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform ObjectToMove;

    public Vector3 newPosition;



    public void OnButtonPress()
    {
        
            ObjectToMove.position = newPosition;
        
    }
}
