using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController
{
    private Rigidbody2D rb2d;

    public MovementController(Rigidbody2D rb2d)
    {
        this.rb2d = rb2d;
    }

    internal void MoveTowards(Vector2 moveAxis)
    {
        rb2d.velocity = moveAxis;
    }
}
