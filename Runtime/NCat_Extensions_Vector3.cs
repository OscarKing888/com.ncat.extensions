using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NCat_Extensions_Vector3
{    
    public static Vector3 AngleBetween180(this Vector3 vAngle)
    {
        if (vAngle.x > 180f)
        {
            vAngle.x -= 360f;
        }
        else if (vAngle.x < -180)
        {
            vAngle.x += 360f;
        }

        if (vAngle.y > 180f)
        {
            vAngle.y -= 360f;
        }
        else if (vAngle.y < -180)
        {
            vAngle.y += 360f;
        }

        if (vAngle.z > 180f)
        {
            vAngle.z -= 360f;
        }
        else if (vAngle.z < -180)
        {
            vAngle.z += 360f;
        }

        return vAngle;
    }

    public static Vector3 AngleTo360(this Vector3 vAngle)
    {
        if (vAngle.x < 0f)
        {
            vAngle.x += 360f;
        }
        else
        {
            vAngle.x = vAngle.x % 360f;
        }

        if (vAngle.y < 0f)
        {
            vAngle.y += 360f;
        }
        else
        {
            vAngle.y = vAngle.y % 360f;
        }

        if (vAngle.z < 0f)
        {
            vAngle.z += 360f;
        }
        else
        {
            vAngle.z = vAngle.z % 360f;
        }

        return vAngle;
    }

    public static Vector3 NormalizedXZ(this Vector3 a)
    {
        Vector3 v = a.normalized;
        v.y = 0;
        return v;
    }

    public static Vector3 XZ(this Vector3 a)
    {
        Vector3 v = a;
        v.y = 0;
        return v;
    }

    public static Vector3 AngleToForward(this Vector3 Angle)
    {
        Vector3 vector = (Vector3)(Quaternion.Euler(Angle) * Vector3.forward);
        return vector.normalized;
    }

    public static Vector3 ForwardRotateAngle(this Vector3 vCurDir, float dgree, Vector3 Axis)
    {
        Vector3 angle = vCurDir.ForwardToAngle() + ((Vector3)(Axis.normalized * dgree));
        return angle.AngleToForward();
    }

    public static Vector3 ForwardToAngle(this Vector3 Forward)
    {
        if (Forward == Vector3.zero)
        {
            return Forward;
        }
        return Quaternion.LookRotation(Forward).eulerAngles;
    }

    public static Vector3 Abs(this Vector3 v)
    {
        return new Vector3(v.x.Abs(), v.y.Abs(), v.z.Abs());
    }

    public static Vector3 Random(Vector3 minBound, Vector3 maxBound)
    {
        Vector3 v = new Vector3(
            UnityEngine.Random.Range(minBound.x, maxBound.x),
            UnityEngine.Random.Range(minBound.y, maxBound.y),
            UnityEngine.Random.Range(minBound.z, maxBound.z)
            );
        return v;
    }

    public static Vector3 RandomXZ(Vector3 minBound, Vector3 maxBound)
    {
        Vector3 v = new Vector3(
            UnityEngine.Random.Range(minBound.x, maxBound.x),
            0,
            UnityEngine.Random.Range(minBound.z, maxBound.z)
            );
        return v;
    }
}
