using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Lerp_Prueba : MonoBehaviour
{
    public Transform A;
    public Transform B;
    public Transform lerpAB;

    [Range(0, 1)]
    public float interpolacion = .5f ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lerpAB.position = Vector3.Lerp( lerpAB.position , A.position, .01f );
    }
}
