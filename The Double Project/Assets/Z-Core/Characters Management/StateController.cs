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
        if (state == null)
        {
            Debug.LogWarning("The state trying to set a null state");
            return;
        }

        if (this.bodyState.GetType() == state.GetType())
            return;

        this.bodyState.DoExit();
        this.bodyState = state;
        this.bodyState.Initialize(this.character);
        this.bodyState.DoStart();
    }

    public void SetLegsState(State state)
    {
        if(state == null)
        {
            Debug.LogWarning("The state trying to set a null state");
            return;
        }

        if (this.legsState.GetType() == state.GetType())
            return;

        this.legsState.DoExit();
        this.legsState = state;
        this.legsState.Initialize(this.character);
        this.legsState.DoStart();
    }

    public abstract State GetNextBodyState(bool forceExitCurrentState);
    public abstract State GetNextLegsState(bool forceExitCurrentState);

}
