using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public string triggerName;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag ("Player"))
        {
            animator.SetTrigger(triggerName);
        }
    }
}
