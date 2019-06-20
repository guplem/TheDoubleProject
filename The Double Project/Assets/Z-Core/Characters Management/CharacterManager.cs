using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterManager : MonoBehaviour
{

    public abstract BrainController brainController { get; set; }
    public abstract StateController stateController { get; set; }
    public CharacterVisualsController characterVisualsController { get; set; }
    public abstract MovementController movementController { get; set; }
    public SoundController soundController;
    [SerializeField] public ColliderController groundCollider;

    public void Start()
    {
        soundController = new SoundController(gameObject);
        characterVisualsController = new CharacterVisualsController();
        DoStart();
    }

    protected abstract void DoStart();

    private void Update()
    {
        stateController.state.DoUpdate(Time.deltaTime);
        brainController.DoUpdate();
    }

    private void FixedUpdate()
    {
        stateController.state.DoFixedUpdate(Time.fixedDeltaTime);
    }
}
