using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayClick : MonoBehaviour
{
   public void Play()
    {
        SceneManager.LoadScene("Juego");
    }
}
