using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemigos : MonoBehaviour
{

    //background scrooll
    //suelo scroll
    //enemigos temática
    //
    
    Rigidbody rigiBody;

    [Range(0, 5)]
    public float velocidad;

    void Start()
    { 
        rigiBody = GetComponent<Rigidbody>();//accedemos a el
        rigiBody.velocity = new Vector3(-velocidad, 0 , 0);//le damos movimiento en la x Negativa
    }

    void Update()
    {
        
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);//destruimos ebjetos al salir de camara
    }

    void OnTriggerEnter(Collider other)//no olvidar marcar is Trigger en CUBO
    {
        if (other.gameObject.tag == "Player")//si cubo choca con objeto player reiniciamos
        {
            tiempoCargaEscena();
            Debug.Log("Reiniciamos la escena");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);//recargamos scena morimos 0,1,2,3
        }
    }

    IEnumerator tiempoCargaEscena() 
    {
        Debug.Log("Mueres condemor");
        yield return new WaitForSeconds(4f);
    }
}
