using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public GameObject [] obstaculos;
    public float minTiempo; 
    public float maxTiempo;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("CrearObstaculo", Random.Range(minTiempo, maxTiempo));
    }

    void CrearObstaculo()
    {
        int random = Random.Range(0,obstaculos.Length);//creamos variable random con el total de objetos
        Instantiate(obstaculos[random], transform.position, obstaculos[random].transform.rotation);
        Invoke("CrearObstaculo", Random.Range(minTiempo, maxTiempo));
    }

    void Update()
    {
        
    }
}
