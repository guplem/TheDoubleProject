using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchIdleState : State
{
    public override void DoStart()
    {
        characterManager.characterVisualsController.PlayAnimation("Crouch_Idle");
        characterManager.characterVisualsController.SetSpeedAnimation(1);
    }

    public override void DoUpdate(float deltaTime)
    {
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        characterManager.movementController.TargetVelocity(Vector2.zero, Vector2.right * 0.1f);
    }

    public override void DoExit()
    {
    }
}