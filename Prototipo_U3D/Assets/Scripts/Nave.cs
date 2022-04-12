using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Nave : MonoBehaviour
{
    public Transform cursorTranformacion ;
    public float velocidadGiro;
    public float maniobra = 1;
    public ParticleSystem explosionFuente;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp( gameObject.transform.position , cursorTranformacion.position, Time.deltaTime * maniobra);

        Vector3 posRelativaCursor = cursorTranformacion.position - gameObject.transform.position ;

        Quaternion ladeo = Quaternion.AngleAxis   ( posRelativaCursor.x * velocidadGiro , Vector3.back )     ;
        Quaternion ladeo2 = Quaternion.AngleAxis  ( posRelativaCursor.x * velocidadGiro / 2 , Vector3.up )   ; 
        Quaternion cabeceo = Quaternion.AngleAxis ( posRelativaCursor.y * velocidadGiro / 2 , Vector3.left ) ; 

        gameObject.transform.rotation = ladeo * cabeceo * ladeo2 ;
    }

    private void OnTriggerEnter( Collider other )
    {
        //Vector3 posMeteoro = other.transform.position ;
        Vector3 posNave = gameObject.transform.position ;
        //Vector3 posRelativa = posMeteoro - posNave ;
        //Vector3 direccion = Vector3.Normalize ( posRelativa ) ;

        ParticleSystem explosion = Instantiate ( explosionFuente, posNave, Quaternion.identity ) ;
        Destroy(explosion.gameObject, 1);

        Debug.Log( "la nave esta colisionando con : " + other.gameObject.name );


    }
}
