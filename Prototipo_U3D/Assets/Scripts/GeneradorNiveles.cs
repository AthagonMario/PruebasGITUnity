using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorNiveles : MonoBehaviour
{
    public EnemigoDato[] enemigosDatos;
    public Texture2D nivelTextura ;

    int cantidadEnemigos ;
    int anchoTextura ;
    int altoTextura ;
    // Start is called before the first frame update
    void Start()
    {
        cantidadEnemigos = enemigosDatos.Length ;
        anchoTextura = nivelTextura.width ;
        altoTextura = nivelTextura.height ;


    }

    private void InstanciarLinea( int linea )
    {
        for ( int i = 0; i < anchoTextura; i++ ) {

            for (int j = 0; j < cantidadEnemigos; j++) {

                if (enemigosDatos[j].color == nivelTextura.GetPixel(i, linea)) { // 1  2  3  4
                    GameObject meteoro = Instantiate(enemigosDatos[j].instanciaFuente, new Vector3( (i - (anchoTextura / 2) ) * 2, 0, 50), Quaternion.identity);
                    meteoro.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -10), ForceMode.Impulse) ;
                }
            }
        }
    }

    float restaTime = 0 ;
    public float intervalo = 2 ;
    int contador = 0 ;
    private void Update()
    { 
        if ( Time.time - restaTime > intervalo ) {

            InstanciarLinea(contador);
            restaTime = Time.time ;
            contador = contador + 1;
        }
        
    }
}

[System.Serializable]
public struct EnemigoDato
{
    public Color color ;
    public GameObject instanciaFuente ;

    public EnemigoDato(Color color, GameObject instanciaFuente)
    {
        this.color = color;
        this.instanciaFuente = instanciaFuente;
    }
}

