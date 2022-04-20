using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float velocidad;
    MeshRenderer meshRenderer;


    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer> () ;



    }

   
    void Update()
    {

        meshRenderer.material.mainTextureOffset = new Vector3(Time.time * velocidad, velocidad, 0);

    }
}
