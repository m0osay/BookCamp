using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    public float time;
    public bool running;
    System.TimeSpan timeSpan;
    // Start is called before the first frame update
    void Start()
    {
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            time += Time.deltaTime;
            timeSpan = System.TimeSpan.FromSeconds(time);
            Debug.Log(timeSpan);
            timeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        }

        

    }

    public void startTimer()
    {
        running = true;
    }

    public void stopTimer()
    {
        running = false;
    }
}
