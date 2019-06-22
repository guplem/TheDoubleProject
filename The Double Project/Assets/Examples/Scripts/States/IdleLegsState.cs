using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IdleLegsState : State
{
    public override void DoStart()
    {
        characterManager.characterVisualsController.PlayAnimation("Idle");
    }

    public override void DoUpdate(float deltaTime)
    {
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        characterManager.movementController.TargetVelocity(Vector2.zero, Vector2.right*0.1f);
    }

    public override void DoExit()
    {
    }
}
