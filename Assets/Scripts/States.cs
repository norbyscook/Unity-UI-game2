using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CanvasProjectStates
{
<<<<<<< HEAD
    // variables storing object references
    // set them in inspector

    // what the current level says
    [TextArea(1, 2)] [SerializeField] string titleText;
    [TextArea(10, 14)] [SerializeField] string levelText;
    

    // the states that player can go to next from this point
    [SerializeField] States[] nextStates;

    public string GetStateBody()
    {
        return levelText;
    }
    
    public string GetStateTitle()
    {
        return titleText;
    }

    public States[] GetNextStates()
=======
    // class that all states will inherit from
    public class States
>>>>>>> states_orginization_v3
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
    }
}
