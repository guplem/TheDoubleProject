using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action
{

    public bool start { get { return _start; } set { _start = value; if (value) ongoing = true; } }
    public bool ongoing { get; private set; }
    public bool stop { get { return _stop; } set { _stop = value; if (value) ongoing = false; } }

    private bool _start;
    private bool _stop;

}
