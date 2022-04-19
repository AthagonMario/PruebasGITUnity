using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteoro : MonoBehaviour
{
    public float velocidadMetrosSegundo = 10;
    Transform hijo;

    Vector3 direccion;

    void Start()
    {
        hijo = gameObject.GetComponentInChildren<Transform>();
        float randomX = Random.Range(-1f, 1f) ;
        float randomY = Random.Range(-1f, 1f) ;
        float randomZ = Random.Range(-1f, 1f) ;
        direccion = Vector3.Normalize(new Vector3(randomX, randomY, randomZ));
    }
     
    void Update()
    { 
        gameObject.transform.position = gameObject.transform.position + new Vector3 ( 0, 0, -1 * velocidadMetrosSegundo ) * Time.deltaTime ;

        if (gameObject.transform.position.z < -10) {
            Destroy( gameObject ) ;
        } 

        Quaternion rot = Quaternion.AngleAxis( 100 * Time.deltaTime  , direccion ) ;
        hijo.rotation = hijo.rotation * rot;
    }
}
