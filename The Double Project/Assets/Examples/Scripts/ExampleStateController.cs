using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleStateController : StateController
{
    public override State GetNextBodyState(bool forceExitCurrentState)
    {
        if (forceExitCurrentState)
            SetLegsState(null);

        return new IdleState();
    }

    public override State GetNextLegsState(bool forceExitCurrentState)
    {
        if (forceExitCurrentState)
            SetLegsState(null);

        State nextState = null;
        if ((nextState = EnterJump()) != null) return nextState;
        if ((nextState = EnterWalk()) != null) return nextState;
        if ((nextState = EnterIdle()) != null) return nextState;


        return null;
    }

    private State EnterWalk()
    {
        if (character.brainController.brain.moveAxis.x == 0)
            return null;

        return new WalkState();
    }

    private State EnterIdle()
    {
        if (character.brainController.brain.moveAxis.x != 0)
            return null;

        return new IdleState();
    }

    private State EnterJump()
    {
        if (!character.brainController.brain.jump.start)
            return null;

        if (!character.groundCollider.inContact)
            return null;

        return new JumpState();
    }
}
