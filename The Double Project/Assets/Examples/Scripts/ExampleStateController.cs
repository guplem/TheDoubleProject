using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleStateController : StateController
{
    public override State GetNextBodyState(bool forceExitCurrentState)
    {
        return null;
    }

    public override State GetNextLegsState(bool forceExitCurrentState)
    {
        return null;
    }
}
