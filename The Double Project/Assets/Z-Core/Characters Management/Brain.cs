using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Brain
{
    public Vector2 moveAxis = new Vector2();
    public Vector2 aimAxis = new Vector2();
    public Action jump = new Action();
    public Action interact = new Action();
    public Action run = new Action();
    public Action crouch = new Action();
    public Action act1 = new Action();
    public Action act2 = new Action();
    public Action act3 = new Action();

    public abstract void DecideAction() ;
}
