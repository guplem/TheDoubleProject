using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class IdleLegsState : State
{
    public override void DoUpdate(float deltaTime)
    {
    }

    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        characterManager.movementController.TargetVelocity(Vector2.zero, Vector2.right*0.1f);
    }

    public override void DoStart()
    {
    }

    public override void DoExit()
    {
    }
}
