using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : Brain
{
    public override void DecideAction()
    {
        moveAxis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
