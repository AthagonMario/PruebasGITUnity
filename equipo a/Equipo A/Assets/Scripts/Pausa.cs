using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{


 
    private Canvas CanvasMenu;
    private bool isShowing=false;
    //public Timer timer;
    //public GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        CanvasMenu = GameObject.FindGameObjectWithTag("menupausa").GetComponent<Canvas>();
        if (isShowing==false)
        {
            CanvasMenu.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown("escape"))
        {
            CanvasMenu.enabled = true;
            isShowing = !isShowing;
            GameController.controller.Pausa(true);
        }
    }
    public void ResumeGame()
    {
        CanvasMenu.enabled = false;
        isShowing = false;
        GameController.controller.Pausa(false);
    }
    public void ReturnToMain()
    {
        GameController.controller.CargarEscena("Inicio");
        GameController.controller.Pausa(true);

    }
    public void Restart()
    {
        CanvasMenu.enabled = false;
        GameController.controller.Pausa(true);
        GameController.controller.IniciarTimer();
        GameController.controller.Pausa(false);

    }
}
