using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasProjectStates
{
    // class that all states will inherit from
    public class States
    {
        protected AdventureGame adventureGameObj;
        public States(AdventureGame adventureGame)
        {
            adventureGameObj = adventureGame;
        }

        // called when each state starts
        public virtual IEnumerator Start()
        {
            yield break;
        }

        #region Button And TextUpdate Checks
        // variable to determine if button has been pressed
        protected bool buttonPressed = false;
        // variable to determine if text has been pressed
        protected bool textUpdated = false;

        // if text is updated 
        protected void TextUpdated()
        {
            // mark button as not pressed
            buttonPressed = false;
            // mark text as updated
            textUpdated = true;
        }

        // if a currect button is pressed 
        protected void ButtonPressed()
        {
            // mark button as pressed
            buttonPressed = true;
            // mark text as not updated
            textUpdated = false;
        }
        #endregion
    }
}
