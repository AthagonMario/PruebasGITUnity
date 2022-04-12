using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterControllerPlataform : MonoBehaviour
{

    [SerializeField] Rigidbody rigidbody;
    // Start is called before the first frame update
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        hit.controller.Move(rigidbody.velocity);
    }

    void On()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
