using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public CharacterManager characterManager { get; private set; }
    public void Initialize(CharacterManager characterManager) {
        if(!characterManager)
        {
            Debug.LogWarning("Trying to initialize state " + this.GetType() + " with null characterManager");
        }

        this.characterManager = characterManager;
    }

    public abstract void DoStart();
    public abstract void DoUpdate(float deltaTime);
    public abstract void DoFixedUpdate(float fixedDeltaTime);
    public abstract void DoExit();

}
