using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public KeyCode teclaIzquierda = KeyCode.LeftArrow ;
    public KeyCode teclaDerecha = KeyCode.RightArrow ;
    public KeyCode teclaArriba = KeyCode.UpArrow ;
    public KeyCode teclaAbajo = KeyCode.DownArrow ;

    public float velocidadMetrosSegundo = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    float movimientoHorizontal = 0 ;
    float movimientoVertical = 0 ; 

    public float AlturaMaxima = 6.01f;
    public float AlturaMinima = -4;
    public float LongitudMinima = -4;
    public float LongitudMaxima = 4;

    void Update()
    { 
        if ( Input.GetKey ( teclaIzquierda ) ) {
            movimientoHorizontal = movimientoHorizontal - velocidadMetrosSegundo * Time.deltaTime ;
            movimientoHorizontal = Mathf.Clamp(movimientoHorizontal, LongitudMinima, LongitudMaxima);
        }        
        if ( Input.GetKey ( teclaDerecha ) ) {  
            movimientoHorizontal = movimientoHorizontal + velocidadMetrosSegundo * Time.deltaTime;
            movimientoHorizontal = Mathf.Clamp(movimientoHorizontal, LongitudMinima, LongitudMaxima);
        }
        if (Input.GetKey(teclaArriba)) {
            movimientoVertical = movimientoVertical + velocidadMetrosSegundo * Time.deltaTime ;
            movimientoVertical = Mathf.Clamp(movimientoVertical, AlturaMinima, AlturaMaxima);
        }
        if (Input.GetKey(teclaAbajo)) {
            movimientoVertical = movimientoVertical - velocidadMetrosSegundo * Time.deltaTime ;
            movimientoVertical = Mathf.Clamp(movimientoVertical, AlturaMinima, AlturaMaxima);
        }
        gameObject.transform.position = new Vector3( movimientoHorizontal , movimientoVertical, 0) ;
    }
}
