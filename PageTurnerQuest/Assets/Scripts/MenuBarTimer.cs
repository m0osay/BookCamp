using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBarTimer : MonoBehaviour
{
    public GameObject timerPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleTimer()
    {
        if (timerPanel.activeInHierarchy)
        {
            timerPanel.SetActive(false);
        }
        else
        {
            timerPanel.SetActive(true);
        }
    }
}
