using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public GameObject [] obstaculos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    void CrearObstaculo()
    {
        int random = Random.Range(0,obstaculos.Length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
