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

        public virtual IEnumerator Start()
        {
            yield break;
        }

        public virtual IEnumerator ChangeState()
        {
            yield break;
        }
    }
}
