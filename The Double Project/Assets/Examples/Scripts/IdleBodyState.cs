using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBodyState : State
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
    }

    public override void DoExit()
    {

    }
}