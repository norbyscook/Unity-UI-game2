using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasProjectStates
{
    public class A1Intro : States
    {
        public A1Intro(AdventureGame adventureGame) : base (adventureGame)
        {
        }
        public override IEnumerator Start()
        {
            // if text is not updated after button as been pressed
            if (!textUpdated)
            {
                // update text once
                adventureGameObj.UpdateText(adventureGameObj.GetStateText());
                TextUpdated();
            }

            // while no correct button is pressed after text has been updated
            while (!buttonPressed)
            {
                // check for button presses
                if (Input.GetKeyDown("space"))
                {
                    ButtonPressed();
                    adventureGameObj.SetState(new A2(adventureGameObj));
                }
                yield return null;
            }
        }
    }
}

