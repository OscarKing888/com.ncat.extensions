using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeSpanExtentions
{
    public static string ToDisplayString(this TimeSpan ts)
    {
        return NCatUtil.ShowTimeSpan(ts);
    }
}
