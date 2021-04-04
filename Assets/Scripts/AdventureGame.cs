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

    #region UI
    public void Set_Text(string text)
    {
        bodyText.text = text;
    }
    #endregion

}
