using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MeteorosController : MonoBehaviour
{
    public GameObject[] meteorosFuente ;
    public float frecuencia = 4;
    public float velocidadMaxima = 30 ;
    public float velocidadminima = 20 ;

    void Start()
    {

    }

    private void instanciadorMeteorito()
    {
        Vector3 pos = RandomPos( -30 , 30 , 50 ) ;

        int longitud = meteorosFuente.Length;
        int randomIndice = Random.Range( 0 , longitud); 
        GameObject meteoro = Instantiate(meteorosFuente[randomIndice], pos, Quaternion.identity) ;
        meteoro.transform.localScale = Vector3.one * Random.Range( 0.5f , 1.2f );

        Rigidbody rigidbody = meteoro.GetComponent<Rigidbody>();
        float velocidad = Random.Range(velocidadminima, velocidadMaxima);

        Vector3 dir = Vector3.Normalize ( RandomPos( -10 , 10 , 0 ) - pos );
        rigidbody.AddForce( dir * velocidad, ForceMode.Impulse);
        rigidbody.AddTorque(dir, ForceMode.Impulse);
    }

    private Vector3 RandomPos ( float min , float max , float profundidad )
    {
        float posX = Random.Range( min, max ) ;
        float posY = Random.Range( min, max ) ;
        Vector3 pos = new Vector3( posX, posY, profundidad) ; 
        return pos;
    }

    float reloj = 0 ;
    void Update()
    {
        reloj = reloj + Time.deltaTime ;
        if (reloj > frecuencia) {
            instanciadorMeteorito();
            reloj = 0 ;
        }
    }
}
