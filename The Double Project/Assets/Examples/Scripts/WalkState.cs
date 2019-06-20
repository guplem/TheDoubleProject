using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : State
{
    public WalkState() {
    }


    public override void DoUpdate(float deltaTime)
    {
        characterManager.movementController.MoveTowards(characterManager.brainController.brain.moveAxis);
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {

    }

}
