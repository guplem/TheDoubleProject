using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateController
{
    protected State defaultBodyState;
    protected State defaultLegsState;
    protected CharacterManager character;
    public State bodyState { get; private set; }
    public State legsState { get; private set; }

    public StateController SetUp(State defaultBodyState, State defaultLegsState, CharacterManager character)
    {
        this.defaultBodyState = defaultBodyState;
        this.defaultLegsState = defaultLegsState;

        this.bodyState = this.defaultBodyState;
        this.legsState = this.defaultLegsState;

        this.character = character;

        return this;
    }

    public void SetBodyState(State state)
    {
        this.bodyState = state;
        this.bodyState.DoStart(this.character);
    }

    public void SetLegsState(State state)
    {
        this.legsState = state;
        this.legsState.DoStart(this.character);
    }

    public abstract State GetNextBodyState(bool forceExitCurrentState);
    public abstract State GetNextLegsState(bool forceExitCurrentState);

}
