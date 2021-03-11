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
    [SerializeField] Text titleText;
    [SerializeField] Text partitionText;

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

    // Start is called before the first frame update
    void Start()
    {
        currentState = gameState1;
        Debug.Log("starting game");
    }

    // Update is called once per frame
    void Update()
    {
        // update state according to user choice
        currentState = stFunc.ManageStates(currentState);
        // update text according to state
        bodyText.text = currentState.GetStateBody();
        titleText.text = currentState.GetStateTitle() + "--Current Partition: " + partitions[currentPartition];
    }


}

