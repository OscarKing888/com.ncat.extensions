using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class NCat_Extensions_List
{
    public static void Resize<T>(this List<T> list, int sz, T c)
    {
        int cur = list.Count;
        if(sz < cur)
            list.RemoveRange(sz, cur - sz);
        else if(sz > cur)
        {
            if(sz > list.Capacity)//this bit is purely an optimisation, to avoid multiple automatic capacity changes.
              list.Capacity = sz;
            list.AddRange(Enumerable.Repeat(c, sz - cur));
        }
    }
    public static void Resize<T>(this List<T> list, int sz) where T : new()
    {
        Resize(list, sz, new T());
    }

    public static void Swap<T>(this IList<T> list, int indexA, int indexB)
    {
        T tmp = list[indexA];
        list[indexA] = list[indexB];
        list[indexB] = tmp;
    }
}
