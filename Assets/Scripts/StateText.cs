using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "statesScrObj")]
public class StateText : ScriptableObject
{
    // variables storing object references
    // set them in inspector
    
    // what the current level says
    [TextArea(10, 14)] [SerializeField] string levelText;

    // the states that player can go to next from this point
    [SerializeField] States[] nextStates;

    public string GetStateText()
    {
        return levelText;
    }
    public States[] GetNextStates()
    {
        return nextStates;
    }
}
