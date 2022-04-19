using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoLinea : MonoBehaviour
{
    public Transform objetoA ;
    public Transform objetoB ;
    public Color color = Color.red;
    // Start is called before the first frame update

    void OnDrawGizmos()
    {
        Gizmos.color = color ;
        Gizmos.DrawLine( objetoA.position , objetoB.position );
    }

}
