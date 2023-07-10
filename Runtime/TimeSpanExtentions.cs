using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TimeSpanExtentions
{
    public static string ToDisplayString(this TimeSpan ts)
    {
        return ShowTimeSpan(ts);
    }

    
    public static string ShowTimeSpan(TimeSpan iTimeSpan, bool needToShowHourAsZero = true)
    {
        if (iTimeSpan.Days > 0)
        {
            object[] args = new object[] { iTimeSpan.Days, iTimeSpan.Hours, iTimeSpan.Minutes, iTimeSpan.Seconds };
            return string.Format("{0}d {1:00}:{2:00}:{3:00}", args);
        }
        else
        {
            if (!needToShowHourAsZero && (iTimeSpan.Hours <= 0))
            {
                return string.Format("{0:00}:{1:00}", iTimeSpan.Minutes, iTimeSpan.Seconds);
            }
            else if (iTimeSpan.Hours <= 0)
            {
                return string.Format("{0:00}:{1:00}", iTimeSpan.Minutes, iTimeSpan.Seconds);
            }
        }
        return string.Format("{0:00}:{1:00}:{2:00}", iTimeSpan.Hours, iTimeSpan.Minutes, iTimeSpan.Seconds);
    }
}
