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
        Vector2 targetVelocity = rb2d.velocity + direction * acceleration;
        SetVelocity(new Vector2(Mathf.Clamp(targetVelocity.x, -maxVelocity.x, maxVelocity.x), Mathf.Clamp(targetVelocity.y, -maxVelocity.y, maxVelocity.y)));
    }

    public void TargetVelocity(Vector2 targetVecloity, Vector2 acceleration)
    {
        Vector2 currentVelocity = rb2d.velocity;

        Vector2 targetVector = targetVecloity - currentVelocity;

        SetVelocity(currentVelocity + new Vector2(acceleration.x * targetVector.x, acceleration.y * targetVector.y));
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

    public Vector2 GetVelocity()
    {
        return rb2d.velocity;
    }

}
