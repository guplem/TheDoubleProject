using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : State
{
    public WalkState() {
    }


    public override void DoUpdate(float deltaTime)
    {
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        characterManager.movementController.MoveTowards(characterManager.brainController.brain.moveAxis, new Vector2(0.5f, 0f), new Vector2(5, 40));
        Debug.Log("Walk");
    }

    public override void DoStart()
    {
    }

    public override void DoExit()
    {
    }
}
