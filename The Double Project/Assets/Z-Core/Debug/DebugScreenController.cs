using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugScreenController : MonoBehaviour
{
    [SerializeField] private Text debugTest;
    [SerializeField] private CharacterManager character;

    private void Update()
    {
        if (Input.GetButtonDown("Debug"))
            debugTest.gameObject.SetActive(!debugTest.gameObject.activeSelf);

        if (!debugTest.gameObject.activeSelf)
            return;

        debugTest.text = "Debug Screen - The Double Project [Developer's Playground]\n" +
            "Player position: " + character.transform.position.x + " X, " + character.transform.position.y + " Y\n" +
            "Player Velocity: " + character.movementController.GetVelocity().x + " X, " + character.movementController.GetVelocity().y + " Y\n" +
            "Player Body State: " + character.stateController.bodyState.ToString() + "\n" +
            "Player Legs State: " + character.stateController.legsState.ToString() + "\n" +
            "Player inContact: " + character.groundCollider.inContact;

    }

}
