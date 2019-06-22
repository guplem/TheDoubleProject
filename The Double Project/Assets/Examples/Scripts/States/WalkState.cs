using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : State
{
    public override void DoStart()
    {
        characterManager.characterVisualsController.PlayAnimation("Run");

    }

    public override void DoUpdate(float deltaTime)
    {
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        characterManager.movementController.MoveTowards(characterManager.brainController.brain.moveAxis, new Vector2(0.5f, 0f), new Vector2(5, 40));
        characterManager.characterVisualsController.SetSpeedAnimation(Mathf.Abs(Utilities.map(characterManager.movementController.GetVelocity().x, 0, 5, 0, 1)));
    }

    public override void DoExit()
    {
    }
}
