using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateController
{
    private State defaultBodyState;
    private State defaultLegsState;
    private CharacterManager character;
    public State bodyState { get; private set; }
    public State legsState { get; private set; }

    public StateController SetUp(State defaultBodyState, State defaultLegsState, CharacterManager character)
    {
        this.defaultBodyState = defaultBodyState;
        this.defaultLegsState = defaultLegsState;
        this.character = character;

        return this;
    }

    private void SetBodyState(State state)
    {
        this.bodyState = state;
        this.bodyState.DoStart(this.character);
    }

    private void SetLegsState(State state)
    {
        this.legsState = state;
        this.legsState.DoStart(this.character);
    }

    public abstract State GetNextBodyState(bool forceExitCurrentState);
    public abstract State GetNextLegsState(bool forceExitCurrentState);

}
