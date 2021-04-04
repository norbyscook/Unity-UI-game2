using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasProjectStates
{
    // class that all states will inherit from
    public class States
    {
        protected AdventureGame AdbentureGameObj;
        public States(AdventureGame adventureGame)
        {
            AdbentureGameObj = adventureGame;
        }
        public virtual IEnumerator Start()
        {
            yield break;
        }
    }
}
