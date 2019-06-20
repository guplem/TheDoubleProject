using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrainController {

    private CharacterManager character;

    public BrainController(Brain brain, CharacterManager character)
    {
        this.brain = brain;
        this.character = character;
    }

    public Brain brain { get; private set; }

    public void DoUpdate()
    {
        SetActionTriggersTo(false);
        brain.DecideAction();
    }

    private void SetActionTriggersTo(bool value)
    {
        brain.jump.start = value;
        brain.jump.stop = value;
        brain.interact.start = value;
        brain.interact.stop = value;
        brain.run.start = value;
        brain.run.stop = value;
        brain.crouch.start = value;
        brain.crouch.stop = value;
        brain.act1.start = value;
        brain.act1.stop = value;
        brain.act2.start = value;
        brain.act2.stop = value;
        brain.act3.start = value;
        brain.act3.stop = value;
    }
}
