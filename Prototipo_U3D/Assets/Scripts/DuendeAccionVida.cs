using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuendeAccionVida : MonoBehaviour
{
    public int vida = 30; 
    public Animator animator ; 

    void Start()
    {
        
    }
     
    void Update()
    {
        if (Input.GetMouseButtonDown (0)) {

            Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition) ;
            RaycastHit choque ;
            if (Physics.Raycast(rayo, out choque)) {

                if (choque.collider.gameObject.name == "Duende") {
                    vida = vida - 10 ;
                }
            }
        }

        ActulizarAnimacion() ;
    }

    private void ActulizarAnimacion()
    {
        if (vida <= 0) {
            animator.SetTrigger("muere") ;
        }
    }
}
