using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchIdleState : State
{
    public override void DoUpdate(float deltaTime)
    {
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        characterManager.movementController.TargetVelocity(Vector2.zero, Vector2.right * 0.1f);
    }

    public override void DoStart()
    {
        characterManager.characterVisualsController.SetTrigger("Crouch_Idle");
    }

    public override void DoExit()
    {
    }
}