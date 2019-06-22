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
    [SerializeField] public SpriteRenderer rightArm, leftArm, rightLeg, leftLeg;
    public CharacterProperties characterProperties;

    public void Start()
    {
        soundController = new SoundController(gameObject);
        characterVisualsController = new CharacterVisualsController(GetComponent<Animator>(), this);
        DoStart();
    }

    protected abstract void DoStart();

    private void Update()
    {
        characterVisualsController.SetCharacterLookDirection();

        stateController.bodyState.DoUpdate(Time.deltaTime);
        stateController.legsState.DoUpdate(Time.deltaTime);
        brainController.DoUpdate();
        stateController.SetBodyState(stateController.GetNextBodyState(false));
        stateController.SetLegsState(stateController.GetNextLegsState(false));

    }

    private void FixedUpdate()
    {
        stateController.bodyState.DoFixedUpdate(Time.fixedDeltaTime);
        stateController.legsState.DoFixedUpdate(Time.fixedDeltaTime);
    }
}
