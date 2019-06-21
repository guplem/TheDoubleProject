using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVisualsController {

    private Animator anim;

    public CharacterVisualsController(Animator anim)
    {
        this.anim = anim;
    }

    public void SetTrigger(string trigger)
    {
        anim.SetTrigger(trigger);
    }


    private void clearTriggers()
    {
        
    }

}
