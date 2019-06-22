using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities
{
    public static float map(float value, float min1, float max1, float min2, float max2)
    {
        if (Mathf.Abs(max1 - min1) < Mathf.Epsilon)
        {
            throw new System.ArithmeticException("/ 0");
        }

        float ratio = (max2 - min2) / (max1 - min1);
        return ratio * (value - min1) + min2;
    }
}
