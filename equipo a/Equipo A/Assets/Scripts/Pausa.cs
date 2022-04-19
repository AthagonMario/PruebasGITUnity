using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    bool paused = false;

    //public GameObject menu; // Assign in inspector
    private Canvas CanvasObject; // Assign in inspector
    private bool isShowing=false;

   
    // Start is called before the first frame update
    void Start()
    {
        paused = false;
        CanvasObject = GetComponent<Canvas>();
        if (isShowing==false)
        {
            CanvasObject.enabled = false;
        }

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown("escape"))
        {        
            Debug.Log("Pausado");
            CanvasObject.enabled = true;
            paused = true;
            isShowing = !isShowing;

        }
    }
    public void ResumeGame()
    {
        Debug.Log("Resume game");
        CanvasObject.enabled = false;
        isShowing = false;
        paused = false;
    }
    public void ReturnToMain()
    {
        SceneManager.LoadScene("Inicio");
    }
}
