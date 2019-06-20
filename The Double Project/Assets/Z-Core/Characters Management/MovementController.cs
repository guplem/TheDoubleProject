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

    public void MoveTowards(Vector2 direction, Vector2 acceleration, Vector2 maxVelocity)
    {
        rb2d.velocity += new Vector2(Mathf.Clamp(acceleration.x * direction.x, -maxVelocity.x, maxVelocity.x), Mathf.Clamp(acceleration.y * direction.y, -maxVelocity.y, maxVelocity.y));
    }

    internal void Impulse(Vector2 force)
    {
        rb2d.AddForce(force, ForceMode2D.Impulse);
    }
}
