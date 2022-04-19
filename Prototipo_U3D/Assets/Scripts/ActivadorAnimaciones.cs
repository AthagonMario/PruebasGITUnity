using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorAnimaciones : MonoBehaviour
{
    public Animator animator ;

    public void activador( string parametro )
    {
        animator.SetTrigger(parametro);
        Debug.Log(parametro);
    }
}
