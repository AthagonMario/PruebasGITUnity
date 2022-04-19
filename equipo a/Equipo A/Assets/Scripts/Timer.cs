using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float StartTime;
    public bool pausa = false;
    public static string tiempo;
    public static Timer Instance
    {
        get;
        set;
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Instance = this;
    }

    void Start()
    {
        StartTime = Time.time;
    }
    void Update()
    {
        if (pausa == false)
        {


            float TimerControl = Time.time - StartTime;
            string mins = ((int)TimerControl / 60).ToString("00");
            string segs = (TimerControl % 60).ToString("00");
            string milisegs = ((TimerControl * 100) % 100).ToString("00");

            string TimerString = string.Format("{00}:{01}:{02}", mins, segs, milisegs);

            GetComponent<Text>().text = TimerString.ToString();
            tiempo = TimerString.ToString();
        }
    }
}
