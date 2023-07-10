using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NCat_Extentions_GameObject
{
    public static T AddMissingComponent<T>(this GameObject obj) where T : Component
    {
        T component = obj.GetComponent<T>();
        if (component == null)
        {
            component = obj.AddComponent<T>();
        }
        return component;
    }

    public static void RemoveComponent<T>(this GameObject obj) where T : Component
    {
        T component = obj.GetComponent<T>();
        if (component != null)
        {
#if UNITY_EDITOR
            if(Application.isPlaying)
            {
                Object.Destroy(component);
            }
            else
            {
                Object.DestroyImmediate(component);
            }
#else
            Object.Destroy(component);
#endif
        }
    }

    public static void SetActive(this Component obj, bool value)
    {
        obj.gameObject.SetActive(value);
    }
}
