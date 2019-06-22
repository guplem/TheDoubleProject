using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DescendingState : State
{
    public override void DoStart()
    {
        characterManager.characterVisualsController.PlayAnimation("Descending");
    }

    public override void DoUpdate(float deltaTime)
    {
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        if (characterManager.brainController.brain.moveAxis.x != 0)
            characterManager.movementController.MoveTowards(characterManager.brainController.brain.moveAxis, new Vector2(.5f, 0f), new Vector2(5, 40));
        else
            characterManager.movementController.TargetVelocity(Vector2.zero, Vector2.right * 0.1f);
    }

    public override void DoExit()
    {

    }
}