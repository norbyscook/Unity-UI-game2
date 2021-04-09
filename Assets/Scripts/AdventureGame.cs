using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CanvasProjectStates;

public class AdventureGame : StateMachine
{
    #region Declarations
    // body text is set in inspector
    // out put for the text display
    [SerializeField] private Text bodyText;
    // TODO change this to start state text
    [SerializeField] private StateText stateText;
    #endregion

    #region Execution
    // Start is called before the first frame update
    void Start()
    {
        // set initial state
        SetState(new A1Intro(this));
        // TODO set starting state text
    }

    // Update is called once per frame
    void Update()
    {
        // print the state texts
        StartCoroutine(currentState.Start());
    }
    #endregion

    #region UI Text Updates
    
    // draws the text onto screen via the text game object
    public void DrawText(string text)
    {
        bodyText.text = text;
    }

    // returns text from the current State Text scriptable object.
    // to be passed into draw text
    public string GetStateText()
    {
        // TODO instead of using the starting state text, use the current state text
        return stateText.GetStateText();
    }
    #endregion
}
