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
    [SerializeField] private StateText stateText;
    #endregion

    #region Execution
    // Start is called before the first frame update
    void Start()
    {
        // set initial state
        SetState(new A1Intro(this));
    }

    // Update is called once per frame
    void Update()
    {
        // print the state texts
        StartCoroutine(currentState.Start());
    }
    #endregion

    #region UI Text Updates
    public void UpdateText(string text)
    {
        bodyText.text = text;
    }
    public string GetStateText()
    {
        return stateText.GetStateText();
    }
    #endregion

}
