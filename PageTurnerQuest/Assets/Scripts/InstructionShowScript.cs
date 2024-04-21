using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionShowScript : MonoBehaviour
{    
    public GameObject instructionPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleInstructions()
    {
        if (instructionPanel.activeInHierarchy)
        {
            instructionPanel.SetActive(false);
        }
        else
        {
            instructionPanel.SetActive(true);
        }
    }
}
