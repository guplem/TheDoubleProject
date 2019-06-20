using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController
{
    private State defaultState;
    private CharacterManager character;

    public StateController(State defaultState, CharacterManager character)
    {
        this.defaultState = defaultState;
        this.character = character;

        SetState(defaultState);
    }

    private void SetState(State state)
    {
        this.state = state;
        this.state.DoStart(this.character);
    }

    public State state { get; private set; }


}
