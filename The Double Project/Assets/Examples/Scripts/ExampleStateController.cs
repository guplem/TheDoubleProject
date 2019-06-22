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

        return defaultBodyState;
    }

    public override State GetNextLegsState(bool forceExitCurrentState)
    {
        if (forceExitCurrentState)
            SetLegsState(null);

        State nextState = null;
        if ((nextState = EnterJump()) != null) return nextState;
        if ((nextState = EnterOnAir()) != null) return nextState;
        if ((nextState = EnterWalk()) != null) return nextState;
        if ((nextState = EnterCrouchWalk()) != null) return nextState;
        if ((nextState = EnterCrouchIdle()) != null) return nextState;
        if ((nextState = EnterIdle()) != null) return nextState;


        return null;
    }

    private State EnterWalk()
    {
        if (legsState.GetType() == typeof(JumpState))
            return null;

        if (character.brainController.brain.moveAxis.x == 0)
            return null;

        if (character.brainController.brain.crouch.ongoing)
            return null;

        if (!character.groundCollider.inContact)
            return null;

        return new WalkState();
    }
    private State EnterCrouchWalk()
    {
        if (legsState.GetType() == typeof(JumpState))
            return null;

        if (character.brainController.brain.moveAxis.x == 0)
            return null;

        if (character.brainController.brain.crouch.ended)
            return null;

        if (!character.groundCollider.inContact)
            return null;

        return new CrouchWalkState();
    }
    private State EnterIdle()
    {
        if (legsState.GetType() == typeof(JumpState))
            return null;

        if (character.brainController.brain.moveAxis.x != 0)
            return null;

        if (character.brainController.brain.crouch.ongoing)
            return null;

        if (!character.groundCollider.inContact)
            return null;

        return new IdleLegsState();
    }
    private State EnterCrouchIdle()
    {
        if (legsState.GetType() == typeof(JumpState))
            return null;

        if (character.brainController.brain.moveAxis.x != 0)
            return null;

        if (character.brainController.brain.crouch.ended)
            return null;

        if (!character.groundCollider.inContact)
            return null;

        return new CrouchIdleState();
    }
    private State EnterOnAir()
    {
        if (character.groundCollider.inContact)
            return null;

        return new OnAirState();
    }
    private State EnterJump()
    {
        if (character.brainController.brain.crouch.ongoing)
            return null;

        if (!character.brainController.brain.jump.start)
            return null;

        if (!character.groundCollider.inContact)
            return null;

        return new JumpState();
    }
}
