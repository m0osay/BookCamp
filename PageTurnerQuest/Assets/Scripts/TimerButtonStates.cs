using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerButtonStates : MonoBehaviour
{
    public enum States {START, READ, STOP, RESET };
    public States state;
    public Text buttonText;
    public Text timerText;
    public float time;
    public bool running;
    System.TimeSpan timeSpan;
    // Start is called before the first frame update
    void Start()
    {
        state = States.START;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == States.READ)
        {
            time += Time.deltaTime;
            timeSpan = System.TimeSpan.FromSeconds(time);
            timerText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
        }
    }

    public void changeState()
    {
        switch (state)
        {
            case States.START:
                state = States.READ;
                buttonText.text = "Stop";
                break;
            case States.READ:
                state = States.STOP;
                buttonText.text = "Reset";
                break;
            case States.STOP:
                state = States.START;
                time = 0f;
                timerText.text = "00:00:00";
                buttonText.text = "Read!";
                break;
            case States.RESET:
                state = States.START;
                buttonText.text = "Read!";
                break;
        }

    }
}
