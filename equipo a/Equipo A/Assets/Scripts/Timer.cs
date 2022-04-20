using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    //public GameController gc;

    void Start()
    {
        
    }
    void Update()
    {                          
        
        GetComponent<Text>().text = GameController.controller.Cronometro();        
    }
}
