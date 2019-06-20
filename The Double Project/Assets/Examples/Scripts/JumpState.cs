using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : State
{
    private float jumpForce = 5f;

    public override void DoStart()
    {
        characterManager.movementController.Impulse(Vector2.up * jumpForce);
    }


    public override void DoFixedUpdate(float fixedDeltaTime)
    {
        
        Debug.Log("JUMP fixed;");

    }

    public override void DoExit()
    {
    }
    

    public override void DoUpdate(float deltaTime)
    {
        Debug.Log("JUMP update;");

    }
}
