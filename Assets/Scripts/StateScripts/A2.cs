using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasProjectStates
{
    public class A2 : States
    {
        public A2(AdventureGame adventureGame) : base (adventureGame)
        {
        }

        public override IEnumerator Start()
        {
            adventureGameObj.UpdateText("A2");
            while (true)
            {

                yield return null;
            }
        }
    }
}