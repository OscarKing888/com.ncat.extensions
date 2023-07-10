using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NCat_Extensions_Transform
{
    public static void DestroyChildren(this Transform trans)
    {
        List<Transform> children = new List<Transform>();
        for (int i = 0; i < trans.childCount; i++)
        {
            children.Add(trans.GetChild(i));
        }

        for (int i = 0; i < children.Count; i++)
        {
            children[i].SetParent(null, true);
        }

        for (int i = 0; i < children.Count; i++)
        {
#if UNITY_EDITOR
            if (Application.isPlaying)
                Object.Destroy(children[i].gameObject);
            else
                Object.DestroyImmediate(children[i].gameObject);
#else
            Object.Destroy (children[i].gameObject);
#endif
        }
    }

    public static void DestroySelfAndChildren(this Transform trans)
    {
        trans.DestroyChildren();
#if UNITY_EDITOR
        if (Application.isPlaying)
            Object.Destroy(trans.gameObject);
        else
            Object.DestroyImmediate(trans.gameObject);
#else
            Object.Destroy(trans.gameObject);
#endif
    }

    public static void DestroyChildren(this GameObject obj)
    {
        obj.transform.DestroyChildren();
    }

    public static void DestroySelfAndChildren(this GameObject obj)
    {
        obj.transform.DestroySelfAndChildren();
    }


    public static GameObject _FindRecursive(Transform transform, string name)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform c = transform.GetChild(i);
            if (c.name.ToLower() == name)
            {
                return c.gameObject;
            }

            if (c.childCount > 0)
            {
                GameObject obj = _FindRecursive(c, name);
                if(obj)
                {
                    return obj;
                }
            }
        }

        return null;
    }

    public static GameObject FindRecursive(this Transform transform, string name)
    {
        return _FindRecursive(transform, name.ToLower());
    }


    public static T GetSafe<T>(this T[] array, int index)
    {
        if (array == null || index < 0 || index > array.Length)
        {
            return default(T);
        }
        return array[index];
    }

    public static void SetGlobalX(this Transform transform, float x)
    {
        var pos = transform.position;
        pos.x = x;
        transform.position = pos;
    }

    public static void SetGlobalY(this Transform transform, float y)
    {
        var pos = transform.position;
        pos.y = y;
        transform.position = pos;
    }

    public static void SetGlobalZ(this Transform transform, float z)
    {
        var pos = transform.position;
        pos.z = z;
        transform.position = pos;
    }

    public static void SetLocalX(this Transform transform, float x)
    {
        var pos = transform.position;
        pos.x = x;
        transform.position = pos;
    }

    public static void SetLocalY(this Transform transform, float y)
    {
        var pos = transform.localPosition;
        pos.y = y;
        transform.localPosition = pos;
    }

    public static void SetLocalZ(this Transform transform, float z)
    {
        var pos = transform.localPosition;
        pos.z = z;
        transform.localPosition = pos;
    }

    public static void SetAnchoredX(this RectTransform transform, float x)
    {
        var pos = transform.anchoredPosition;
        pos.x = x;
        transform.anchoredPosition = pos;
    }

    public static void SetAnchoredY(this RectTransform transform, float y)
    {
        var pos = transform.anchoredPosition;
        pos.y = y;
        transform.anchoredPosition = pos;
    }

    public static void SetAnchoredZ(this RectTransform transform, float z)
    {
        var pos = transform.anchoredPosition3D;
        pos.z = z;
        transform.anchoredPosition3D = pos;
    }
}
