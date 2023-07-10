using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RemoteSettingsEx
{
    public static int[] GetIntList(string key, string defaultStr = "")
    {
        List<int> outList = new List<int>();
        try
        {
            string str = RemoteSettings.GetString(key, defaultStr);
#if DEVELOPMENT_BUILD || UNITY_EDITOR
            //NCat.DebugEx.LogFormatColorRed("[RemoteSettingsEx] GetIntList:{0}", str);
#endif
            string[] splitList = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitList.Length; i++)
            {
                if (int.TryParse(splitList[i], out int v))
                {
                    outList.Add(v);
                }
            }
        }
        catch (Exception e)
        {
            UnityEngine.Debug.LogErrorFormat("[RemoteSettingsEx] Parse int value error:{0}", e.Message);
        }

        return outList.ToArray();
    }

    public static float[] GetFloatList(string key, string defaultStr = "")
    {
        List<float> outList = new List<float>();
        try
        {
            string str = RemoteSettings.GetString(key, defaultStr);
#if DEVELOPMENT_BUILD || UNITY_EDITOR
            //NCat.DebugEx.LogFormatColorRed("[RemoteSettingsEx] GetFloatList:{0}", str);
#endif
            string[] splitList = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitList.Length; i++)
            {
                if (float.TryParse(splitList[i], out float v))
                {
                    outList.Add(v);
                }
            }
        }
        catch (Exception e)
        {
            UnityEngine.Debug.LogErrorFormat("[RemoteSettingsEx] Parse float value error:{0}", e.Message);
        }

        return outList.ToArray();
    }

    public static Dictionary<string, int> GetIntDictionary(string key, string defaultStr = "")
    {
        Dictionary<string, int> outList = new Dictionary<string, int>();
        try
        {
            string str = RemoteSettings.GetString(key, defaultStr);
#if DEVELOPMENT_BUILD || UNITY_EDITOR
            //NCat.DebugEx.LogFormatColorRed("[RemoteSettingsEx] GetIntDictionary:{0}", str);
#endif
            string[] splitList = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitList.Length; i++)
            {
                string[] kvPair = splitList[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                if (int.TryParse(kvPair[1], out int v))
                {
                    outList.Add(kvPair[0], v);
                }
                else
                {
                    UnityEngine.Debug.LogErrorFormat("[RemoteSettingsEx] [GetIntDictionary'] failed to parse int:{0}", splitList[i]);
                }
            }
        }
        catch (Exception e)
        {
            UnityEngine.Debug.LogErrorFormat("[RemoteSettingsEx] [GetIntDictionary] error:{0}", e.Message);
        }

        return outList;
    }

    public static Dictionary<string, float> GetFloatDictionary(string key, string defaultStr = "")
    {
        Dictionary<string, float> outList = new Dictionary<string, float>();
        try
        {
            string str = RemoteSettings.GetString(key, defaultStr);
#if DEVELOPMENT_BUILD || UNITY_EDITOR
            //NCat.DebugEx.LogFormatColorRed("[RemoteSettingsEx] GetFloatDictionary:{0}", str);
#endif

            string[] splitList = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splitList.Length; i++)
            {
                string[] kvPair = splitList[i].Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                if (float.TryParse(kvPair[1], out float v))
                {
                    outList.Add(kvPair[0], v);
                }
                else
                {
                    UnityEngine.Debug.LogErrorFormat("[RemoteSettingsEx] [GetFloatDictionary'] failed to parse float:{0}", splitList[i]);
                }
            }
        }
        catch (Exception e)
        {
            UnityEngine.Debug.LogErrorFormat("[RemoteSettingsEx] [GetFloatDictionary] error:{0}", e.Message);
        }

        return outList;
    }


}
