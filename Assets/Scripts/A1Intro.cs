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
            while (true)
            {
                yield return null;
            }
        }
    }
}
