using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayClick : MonoBehaviour
{
    public Timer time;
    void Start()
    {
       // GetComponent<Text>().text = time.tiempo;
    }
        public void Play()
    {
        SceneManager.LoadScene("Juego");
    }
}
