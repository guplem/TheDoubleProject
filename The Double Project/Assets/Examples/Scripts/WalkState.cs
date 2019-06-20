using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : State
{
    public WalkState() {
    }


    public override void DoUpdate(float deltaTime)
    {
        characterManager.movementController.MoveTowards(characterManager.brainController.brain.moveAxis, new Vector2(0.5f, 0f), new Vector2(5f, 0f));
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        Debug.Log("Walk");
    }

}
