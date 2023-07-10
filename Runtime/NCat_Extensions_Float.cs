using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class NCat_Extensions_Float
{    
    public static string ToStringShort(this double v, int cnt = 3)
    {
        return NCatUtil.ShowDoubleInShortString(v, cnt);
    }

    public static string ToStringPercent(this double v)
    {
        int minutes = Mathf.CeilToInt((float)(v * 100));

        return string.Format("{0}%", minutes);
    }
        

    public static string ToStringTime(this float time)
    {
        time = Mathf.Abs(time);
        int minutes = (int)time / 60;
        int seconds = (int)time - 60 * minutes;
        int milliseconds = (int)(100 * (time - minutes * 60 - seconds));
        return string.Format("{0:00}:{1:00}:{2:00}", minutes, seconds, milliseconds);
    }

    public static string ToStringTime(this float time, string format)
    {
        int minutes = (int)time / 60;
        int seconds = (int)time - 60 * minutes;
        int milliseconds = (int)(1000 * (time - minutes * 60 - seconds));
        return string.Format(format, minutes, seconds, milliseconds);
    }

    public static string ToStringPercent(this float time)
    {
        int minutes = Mathf.CeilToInt(time * 100);

        return string.Format("{0}%", minutes);
    }
}
