using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasProjectStates
{

    public class StateMachine : MonoBehaviour
    {
        protected States currentState;

        public void SetState(States state)
        {
            currentState = state;
            StartCoroutine(state.Start());
        }


    }

}
