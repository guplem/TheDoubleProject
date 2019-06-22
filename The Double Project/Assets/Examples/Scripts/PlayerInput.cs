using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : Brain
{
    public override void DecideAction()
    {
        moveAxis = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"));
        jump.start = Input.GetButtonDown("Jump");
        crouch.ongoing = Input.GetButton("Crouch");
        crouch.ended = !Input.GetButton("Crouch");
    }
}
