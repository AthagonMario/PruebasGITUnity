using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoEsfera : MonoBehaviour
{
    public Color color = Color.red ;
    public float radio = 1f ;
    // Start is called before the first frame update
    void OnDrawGizmos()
    {
        Gizmos.color = color ;
        Gizmos.DrawWireSphere(gameObject.transform.position, radio ) ;
    } 
}
