using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public static class HandlesEx
{
    public static void RectangleCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
        Handles.RectangleHandleCap(controlID, position, rotation, size, EventType.MouseMove);
    }

    public static void ConeCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
        Handles.ConeHandleCap(controlID, position, rotation, size, EventType.MouseMove);
    }

    public static void SphereCap(int controlID, Vector3 position, Quaternion rotation, float size)
    {
        Handles.SphereHandleCap(controlID, position, rotation, size, EventType.MouseMove);
    }
}

