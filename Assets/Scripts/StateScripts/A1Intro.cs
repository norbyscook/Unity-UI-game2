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
            adventureGameObj.UpdateText(adventureGameObj.GetStateText());
            // check for state changes
            yield break;
        }

        public override IEnumerator ChangeState()
        {
            if (Input.GetKeyDown("space"))
            {
                adventureGameObj.SetState(new A2(adventureGameObj));
            }
            return base.ChangeState();
        }
    }
}

