using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : State
{
    private float jumpForce = 10f;

    public override void DoStart()
    {
    }


    public override void DoFixedUpdate(float fixedDeltaTime)
    {
    }

    public override void DoExit()
    {
        characterManager.movementController.Impulse(Vector2.up * jumpForce);
        
    }
    

    public override void DoUpdate(float deltaTime)
    {
    }
}
