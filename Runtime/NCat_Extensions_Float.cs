using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class NCat_Extensions_Float
{    
    public static string ToStringShort(this double v, int cnt = 3)
    {
        return ShowDoubleInShortString(v, cnt);
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

    
    public static string ShowDoubleInShortString(double iValue, int cnt = 3)
    {
        string str2;
        string str3;
        bool flag = true;
        if (double.IsNaN(iValue))
        {
#if UNITY_EDITOR
            return "NaN";
#else
            return "???";
#endif
        }

        string str = iValue.ToString("e5");
        int index = str.IndexOf("e");
        if (index >= 0)
        {
            int result = 0;
            string tmpStr = str.Substring(index + 1);
            int.TryParse(tmpStr, out result);
            str2 = str.Substring(0, index);
            str3 = string.Empty;
            if ((result < 3) || ((result < 6) && !flag))
            {
                if (iValue < 1.0)
                {
                    float num4 = ((float)((int)(iValue * 100.0))) / 100f;
                    return num4.ToString();
                }
                return System.Math.Floor(iValue).ToString();
            }

            if (true)
            {
                str2 = str2.Remove(1, 1).Remove(3 + (result % 3)).Insert(1 + (result % 3), ".");
            }
            else
            {
                string str21 = str2.Remove(1, 1);
                string str22 = str21.Remove(cnt + (result % cnt));
                str2 = str22.Insert(1 + (result % cnt), ".");

                //str2 = str2.Substring(0, cnt + 2);
            }

            int num3 = result / 3;
            if (true)
            {
                if (num3 < 2)
                {
                    str3 = "K";
                    goto Label_037F;
                }
                if (num3 < 3)
                {
                    str3 = "M";
                    goto Label_037F;
                }
                if (num3 < 4)
                {
                    str3 = "B";
                    goto Label_037F;
                }
                if (num3 < 5)
                {
                    str3 = "T";
                    goto Label_037F;
                }
                if (num3 < 6)
                {
                    str3 = "aa";
                    goto Label_037F;
                }
                if (num3 < 7)
                {
                    str3 = "bb";
                    goto Label_037F;
                }
                if (num3 < 8)
                {
                    str3 = "cc";
                    goto Label_037F;
                }
                if (num3 < 9)
                {
                    str3 = "dd";
                    goto Label_037F;
                }
                if (num3 < 10)
                {
                    str3 = "ee";
                    goto Label_037F;
                }
                if (num3 < 11)
                {
                    str3 = "ff";
                    goto Label_037F;
                }
                if (num3 < 12)
                {
                    str3 = "gg";
                    goto Label_037F;
                }
                if (num3 < 13)
                {
                    str3 = "hh";
                    goto Label_037F;
                }
                if (num3 < 14)
                {
                    str3 = "ii";
                    goto Label_037F;
                }
                if (num3 < 15)
                {
                    str3 = "jj";
                    goto Label_037F;
                }
                if (num3 < 0x10)
                {
                    str3 = "kk";
                    goto Label_037F;
                }
                if (num3 < 0x11)
                {
                    str3 = "ll";
                    goto Label_037F;
                }
                if (num3 < 0x12)
                {
                    str3 = "mm";
                    goto Label_037F;
                }
                if (num3 < 0x13)
                {
                    str3 = "nn";
                    goto Label_037F;
                }
                if (num3 < 20)
                {
                    str3 = "oo";
                    goto Label_037F;
                }
                if (num3 < 0x15)
                {
                    str3 = "pp";
                    goto Label_037F;
                }
                if (num3 < 0x16)
                {
                    str3 = "qq";
                    goto Label_037F;
                }
                if (num3 < 0x17)
                {
                    str3 = "rr";
                    goto Label_037F;
                }
                if (num3 < 0x18)
                {
                    str3 = "ss";
                    goto Label_037F;
                }
                if (num3 < 0x19)
                {
                    str3 = "tt";
                    goto Label_037F;
                }
                if (num3 < 0x1a)
                {
                    str3 = "uu";
                    goto Label_037F;
                }
                if (num3 < 0x1b)
                {
                    str3 = "vv";
                    goto Label_037F;
                }
                if (num3 < 0x1c)
                {
                    str3 = "ww";
                    goto Label_037F;
                }
                if (num3 < 0x1d)
                {
                    str3 = "xx";
                    goto Label_037F;
                }
                if (num3 < 30)
                {
                    str3 = "yy";
                    goto Label_037F;
                }
                if (num3 < 0x1f)
                {
                    str3 = "zz";
                    goto Label_037F;
                }
            }
        }
        return iValue.ToString("G3");
    Label_037F:
        return (str2 + str3);
    }
}
