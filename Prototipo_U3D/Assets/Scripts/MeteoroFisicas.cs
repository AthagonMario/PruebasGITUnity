using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroFisicas : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    { 
        if (gameObject.transform.position.z < -10) {
            Destroy(gameObject);
        }
    }
}
