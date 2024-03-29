﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : State
{
    private float jumpForce = 5f;

    public override void DoStart()
    {
        characterManager.movementController.Impulse(Vector2.up * jumpForce);
        //characterManager.characterVisualsController.SetTrigger("Jump");
    }


    public override void DoFixedUpdate(float fixedDeltaTime)
    {
    }

    public override void DoExit()
    {
    }
    

    public override void DoUpdate(float deltaTime)
    {
    }
}
