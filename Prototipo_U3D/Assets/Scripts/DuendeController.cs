using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuendeController : MonoBehaviour
{
    [SerializeField] CharacterController characterController ;
    [SerializeField] Animator animator ;
    [SerializeField] bool tocaSuelo ;
    [SerializeField] LayerMask capa = 0;
    [SerializeField] AnimationCurve saltoForma;

    void Start()
    {
        
    }

    bool saltando;
    Vector3 dirSalto = Vector3.zero;
    void Update()
    {
        tocaSuelo = Physics.CheckSphere ( transform.position , 0.05f , capa ) ;

        Vector3 desplazamiento = new Vector3( Input.GetAxis ("Horizontal") , 0 , Input.GetAxis("Vertical")) * Time.deltaTime ;

        if (tocaSuelo) {
            if ( desplazamiento != Vector3.zero ) {

                characterController.Move ( desplazamiento ) ;
                animator.SetBool("Andando" , true ) ;
                Quaternion direccion = Quaternion.LookRotation( desplazamiento , Vector3.up ) ;
                transform.rotation = direccion ;
            } else {
                animator.SetBool("Andando", false) ; 
            }  
            if (Input.GetKeyDown ( KeyCode.Space )) {
                saltando = true ; 
                tocaSuelo = false;
                dirSalto = desplazamiento * 0.5f;
            } 
        } else {
            characterController.Move(new Vector3(0, -2, 0) * Time.deltaTime) ;  
        }

        if (saltando ) {
            Saltando();
        } 
    } 
    float tiempoSalto = 0 ;
    void Saltando ()
    {
        tiempoSalto = tiempoSalto + Time.deltaTime ;
        float impulso = saltoForma.Evaluate( tiempoSalto ) * Time.deltaTime * 5  ;
        characterController.Move( new Vector3(0, impulso , 0) + dirSalto ) ;

        if (tocaSuelo) {
            saltando = false ;
            tiempoSalto = 0;
        }
    }
}
