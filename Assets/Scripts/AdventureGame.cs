using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // variables storing object references
    // set them in inspector
    // gives us access to what the viewer sees on display
    [SerializeField] Text bodyText;

    // gives us access to the 1st state, it's text and other features
    [SerializeField] States gameState1;

    // stores current state
    [SerializeField] States currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = gameState1;
        Debug.Log("starting game");
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();
        bodyText.text = currentState.GetStateText();
    }

    void ManageStates()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            States[] nextStates = currentState.GetNextStates();
            currentState = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            States[] nextStates = currentState.GetNextStates();
            currentState = nextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            States[] nextStates = currentState.GetNextStates();
            currentState = nextStates[2];
        }

    }
}

