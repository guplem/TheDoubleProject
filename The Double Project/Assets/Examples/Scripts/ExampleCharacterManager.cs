using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleCharacterManager : CharacterManager
{
    public override BrainController brainController { get; set; }
    public override StateController stateController { get; set; }
    public override MovementController movementController { get; set; }

    protected override void DoStart()
    {
        brainController = new BrainController(new PlayerInput(), this) ;
        stateController = new ExampleStateController().SetUp(new IdleState(), new IdleState(), this);
        movementController = new MovementController(GetComponent<Rigidbody2D>());
    }
}
