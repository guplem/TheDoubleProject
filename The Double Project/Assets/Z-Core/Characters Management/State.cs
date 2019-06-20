using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public CharacterManager characterManager { get; private set; }
    public void DoStart(CharacterManager characterManager) {
        this.characterManager = characterManager;
    }

    public abstract void DoUpdate(float deltaTime);
    public abstract void DoFixedUpdate(float fixedDeltaTime);
}
