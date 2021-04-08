using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CanvasProjectStates;

public class AdventureGame : MonoBehaviour
{
<<<<<<< HEAD
    // variables storing object references
    // set them in inspector
    // gives us access to what the viewer sees on display
    [SerializeField] Text bodyText;
    [SerializeField] Text titleText;

    // gives us access to the 1st state, it's text and other features
    [SerializeField] States gameState1;

    // stores current state
    // serialized to debug, other wise this should be private
    [SerializeField] States currentState;

    // all state related functions
    StateFunctions stFunc = new StateFunctions();

    // partition states
    string[] partitions = new string[2] { "D", "X" };
    int currentPartition = 0;

=======
    #region Declarations
    // body text is set in inspector
    // out put for the text display
    [SerializeField] private Text bodyText;
    [SerializeField] private StateText stateText;
    #endregion
    #region Execution
>>>>>>> states_orginization_v3
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("starting game");
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        // update state according to user choice
        currentState = stFunc.ManageStates(currentState);
        // update text according to state
        bodyText.text = currentState.GetStateBody();
        titleText.text = currentState.GetStateTitle() + "--Current Partition: " + partitions[currentPartition];
=======
        StartCoroutine(new A1Intro(this).Start());
    }
    #endregion

    #region State changes
    void ManageStates()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {

        }

>>>>>>> states_orginization_v3
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
