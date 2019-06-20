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
        Vector2 velocity = rb2d.velocity;

        velocity += new Vector2(acceleration.x * direction.x, acceleration.y * direction.y);
        SetVelocity(new Vector2(Mathf.Clamp(velocity.x, -maxVelocity.x, maxVelocity.x), Mathf.Clamp(velocity.y, -maxVelocity.y, maxVelocity.y)));
    }

    public void Impulse(Vector2 force)
    {
        rb2d.AddForce(force, ForceMode2D.Impulse);
    }

    public void SetVelocity(Vector2 velocity)
    {
        rb2d.velocity = velocity;
    }

    public void SetHorVelocity(float hor)
    {
        SetVelocity(new Vector2(hor, rb2d.velocity.y));
    }
    public void SetVertVelocity(float vert)
    {
        SetVelocity(new Vector2(rb2d.velocity.x, vert));
    }

}
