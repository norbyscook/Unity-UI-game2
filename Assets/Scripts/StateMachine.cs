using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasProjectStates
{
    
    // encapsulates fields and methods related to state changes
    public class StateMachine : MonoBehaviour
    {
        protected States currentState;
        //  TODO add another reference variable here to track current state text

        public void SetState(States state)
        {
            currentState = state;
            StartCoroutine(state.Start());
        }

        // TODO function to update state text
    }
}
