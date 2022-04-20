using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameController controller;
    public float StartTime;
    private bool pausado = false;
    public static string TimerString = "";
    void Start()
    {
        GetComponent<Text>().text = ultimoTiempo();
    }
    private void Awake()
    {
        if (controller == null)
        {
            controller = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("crea");
        }
        else if(controller != this){
            Destroy(gameObject);
            Debug.Log("destroy");
        }
        
    }

     
    public void CargarEscena (string nombreEscena)
    {
        if (nombreEscena == "Juego")
        {
            Pausa(false);
            IniciarTimer();
        }
        SceneManager.LoadScene(nombreEscena);
        Debug.Log("Carga: " + nombreEscena);
    }

    public string Cronometro()
    {
       
        if (pausado == false)
        {
            float TimerControl = Time.time - StartTime;
            string mins = ((int)TimerControl / 60).ToString("00");
            string segs = (TimerControl % 60).ToString("00");
            string milisegs = ((TimerControl * 100) % 100).ToString("00");

            TimerString = string.Format("{00}:{01}:{02}", mins, segs, milisegs);           
        }
        return TimerString;
    }
    public void Pausa(bool pausar)
    {
        pausado = pausar;
    }
    public string ultimoTiempo()
    {
        Pausa(true);
        if (TimerString != "")
        {
            return Cronometro();
        }
        else
        {
            return "0:00:00";
        }
        
    }
    public void IniciarTimer()
    {
        StartTime = Time.time;
    }
}
