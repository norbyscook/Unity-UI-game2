using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CanvasProjectStates;

public class AdventureGame : MonoBehaviour
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
        Debug.Log("starting game");
    }

    // Update is called once per frame
    void Update()
    {
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

    }
    #endregion

    #region UI Text Updates
    public void SetText(string text)
    {
        bodyText.text = text;
    }
    public string GetStateText()
    {
        return stateText.GetStateText();
    }
    #endregion

}
