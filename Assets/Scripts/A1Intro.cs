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
            while (true)
            {
                AdbentureGameObj.Set_Text("test");
                yield return null;
            }
        }
    }
}
