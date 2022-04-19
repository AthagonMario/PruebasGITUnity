using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public float velocidadBola = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float segundero = 0 ;
    // Update is called once per frame
    void Update()
    {
        segundero = segundero + Time.deltaTime ;
        Vector3 mov = gameObject.transform.forward * Time.deltaTime * velocidadBola ;
        Vector3 grav = new Vector3(0, -1, 0) * (segundero * segundero * .1f ) ;
        gameObject.transform.position = gameObject.transform.position + mov + grav ;

        if (gameObject.transform.position.y < 0) {

            Destroy(gameObject);
        }
    }
}
