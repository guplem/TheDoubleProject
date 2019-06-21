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
    public CharacterProperties characterProperties;

    public void Start()
    {
        soundController = new SoundController(gameObject);
        characterVisualsController = new CharacterVisualsController(GetComponent<Animator>());
        DoStart();
    }

    protected abstract void DoStart();

    private void Update()
    {
        stateController.bodyState.DoUpdate(Time.deltaTime);
        stateController.legsState.DoUpdate(Time.deltaTime);
        brainController.DoUpdate();
        stateController.SetBodyState(stateController.GetNextBodyState(false));

        State newLegsState = stateController.GetNextLegsState(false);
        if(newLegsState.GetType() != stateController.legsState.GetType())
            stateController.SetLegsState(newLegsState);
    }

    private void FixedUpdate()
    {

        if (movementController.GetVelocity().x > 0)
            transform.localScale = Vector3.one;
        else if (movementController.GetVelocity().x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        stateController.bodyState.DoFixedUpdate(Time.fixedDeltaTime);
        stateController.legsState.DoFixedUpdate(Time.fixedDeltaTime);
    }
}
