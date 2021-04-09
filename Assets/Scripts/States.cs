using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasProjectStates
{
    // class that all states will inherit from
    public class States
    {
        #region Declaration
        protected AdventureGame adventureGameObj;
        public States(AdventureGame adventureGame)
        {
            adventureGameObj = adventureGame;
        }
        // variable to determine if button has been pressed
        protected bool stateChanged = false;
        // variable to determine if text has been pressed
        protected bool textUpdated = false;
        #endregion

        #region Execution
        // called when each state starts
        public virtual IEnumerator Start()
        {
            // update text
            adventureGameObj.StartCoroutine(UpdateText());
            // check for state changes
            adventureGameObj.StartCoroutine(ChangeStates());

            yield break;
        }
        
        public virtual IEnumerator ChangeStates()
        {
            // while state has not changed
            while (!stateChanged)
            {
                // check for button presses
                if (Input.GetKeyDown("space"))
                {
                    StateChanged();
                    adventureGameObj.SetState(new A2(adventureGameObj));
                }
                yield return null;
            }
        }
        
        public virtual IEnumerator UpdateText()
        {
            // if text is not updated after state has been changed
            if (!textUpdated)
            {
                // update text once
                adventureGameObj.UpdateText(adventureGameObj.GetStateText());
                TextUpdated();
            }
            yield break;
        }
        #endregion

        #region Button And TextUpdate Checks

        // if text is updated 
        protected void TextUpdated()
        {
            // mark button as not pressed
            stateChanged = false;
            // mark text as updated
            textUpdated = true;
        }

        // if a currect button is pressed 
        protected void StateChanged()
        {
            // mark button as pressed
            stateChanged = true;
            // mark text as not updated
            textUpdated = false;
        }
        #endregion
    }
}
