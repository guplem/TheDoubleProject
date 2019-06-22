using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVisualsController {

    private Animator anim;
    private CharacterManager characterManager;

    public CharacterVisualsController(Animator anim, CharacterManager characterManager)
    {
        this.anim = anim;
        this.characterManager = characterManager;
    }

    public void PlayAnimation(string trigger)
    {
        SetSpeedAnimation(1);
        anim.SetTrigger(trigger);
    }

    public void PlayAnimation(string trigger, float speed)
    {
        SetSpeedAnimation(speed);
        anim.SetTrigger(trigger);
    }

    public void SetSpeedAnimation(float speed)
    {
        anim.speed = speed;
    }

    public void SetCharacterLookDirection()
    {
        if (characterManager.movementController.GetVelocity().x > 0)
        {
            if (characterManager.transform.localScale != Vector3.one)
            {
                characterManager.transform.localScale = Vector3.one;
                flipBodyElements();
            }
        }
        else if (characterManager.movementController.GetVelocity().x < 0)
        {
            if (characterManager.transform.localScale != new Vector3(-1, 1, 1))
            {
                characterManager.transform.localScale = new Vector3(-1, 1, 1);
                flipBodyElements();
            }
        }
    }

    private void flipBodyElements()
    {
        int leftArm = characterManager.leftArm.sortingOrder;
        characterManager.leftArm.sortingOrder = characterManager.rightArm.sortingOrder;
        characterManager.rightArm.sortingOrder = leftArm;
        int leftLeg = characterManager.leftLeg.sortingOrder;
        characterManager.leftLeg.sortingOrder = characterManager.rightLeg.sortingOrder;
        characterManager.rightLeg.sortingOrder = leftLeg;
    }

}
