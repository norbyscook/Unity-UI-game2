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
        
    }
    
    int input = -1;
    private void OnGUI()
    {
        input = IntInput(input);
        bodyText.text = input.ToString();
    }
    int IntInput(int input)
    {
        Event e = Event.current;
        if (e.isKey && (int)e.keyCode > 0)
        {
            return (int)e.keyCode - (int)KeyCode.Alpha0;
        }
        return input;
    }
}

