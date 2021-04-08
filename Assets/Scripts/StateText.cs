using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "StatesTextObj")]
public class StateText : ScriptableObject
{
    // variables storing object references
    // set them in inspector
    
    // what the current level says
    [TextArea(10, 14)] [SerializeField] string levelText;

    public string GetStateText()
    {
        return levelText;
    }
}
