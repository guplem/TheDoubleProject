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
        Debug.Log("Idle");
    }

    public override void DoStart()
    {
        characterManager.movementController.SetVelocity(Vector2.zero);
    }

    public override void DoExit()
    {
        
    }
}
