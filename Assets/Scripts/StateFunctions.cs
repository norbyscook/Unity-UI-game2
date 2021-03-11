using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateFunctions : MonoBehaviour
{
    
    public States ManageStates(States currentState)
    {
        // update state according to user choice

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

        return currentState;
    }
}
