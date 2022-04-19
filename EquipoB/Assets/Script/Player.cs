using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody rB;

    //Movimiento

    public float fuerzaSalto = 5.0f;
    public bool puedoSaltar = false; //Verifica si toca el suelo
    public bool sueloDetectado = false;

    // Start is called before the first frame update
    void Start()
    {
        rB = GetComponent<Rigidbody>(); 

        //Añadir Animator

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        ComprobarSalto();

        TocandoSuelo();
    }

    public void ComprobarSalto()
    {
        puedoSaltar = Input.GetButtonDown("Jump");
        if (puedoSaltar && sueloDetectado)
        {
            //rB.velocity = 
            rB.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
        }
    }

    void TocandoSuelo()
    {
        //Salto
        Vector3 suelo = transform.TransformDirection(Vector3.down);
        if (Physics.Raycast(transform.position, suelo, 1.03f))
        {
            sueloDetectado = true;
            print("Contacto con el suelo");
        }
        else
        {
            sueloDetectado = false;
            print("No hay contacto con el suelo");
        }
    }
}
