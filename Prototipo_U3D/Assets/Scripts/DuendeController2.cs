using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuendeController2 : MonoBehaviour
{
    CharacterController characterController;
    [SerializeField] Animator animator;
    [SerializeField] const float gravedad = 9.81f;
    [SerializeField] float velocidad = 3f;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    float direccionY = 0;

    void Update()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");
        Vector3 direccionInput = new Vector3(inputHorizontal, 0, inputVertical);
        Vector3 direccion = new Vector3(inputHorizontal, direccionY, inputVertical);

        animator.SetBool("PiesSuelo", characterController.isGrounded);

        if (characterController.isGrounded) {


            if (Input.GetButton("Jump")) {
                direccionY = 4f;
            }

            if (direccionInput != Vector3.zero) {

                Quaternion rotacion = Quaternion.LookRotation(direccionInput.normalized, Vector3.up);
                rotacion = Quaternion.Slerp(transform.rotation, rotacion, Time.deltaTime * 10);
                transform.rotation = rotacion;
                animator.SetBool("Andando", true);
            } else {
                animator.SetBool("Andando", false);
            }

        } else {
            direccionY = direccionY - gravedad * Time.deltaTime;

            animator.SetFloat("Altura", direccionY);
        }

        characterController.Move(direccion * Time.deltaTime * velocidad);
         
        //void OnControllerColliderHit(ControllerColliderHit hit) 
        //{
        //    Debug.Log( hit.gameObject.name );
        //    gameObject.transform.parent = hit.collider.transform; 
        //}
    }
}
