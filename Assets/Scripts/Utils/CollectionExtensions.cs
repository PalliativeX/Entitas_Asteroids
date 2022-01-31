using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CollectionExtensions
{
    public static void ForEach<T>(this T[] array, System.Action<T> callback) where T : Component
    {
        for (var i = 0; i < array.Length; i++)
        {
            callback.Invoke(array[i]);
        }
    }

    public static T GetRandom<T>(this T[] arr)
    {
        return arr[Random.Range(0, arr.Length)];
    }

    public static T GetRandom<T>(this List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    public static T GetRandomExcept<T>(this T[] arr, T ignored) where T : MonoBehaviour
    {
        T random;
        do
            random = arr[Random.Range(0, arr.Length)];
        while (random == ignored);

        return random;
    }

    public static T GetRandomExcept<T>(this List<T> list, T ignored) where T : MonoBehaviour
    {
        T random;
        do
            random = list[Random.Range(0, list.Count)];
        while (random == ignored);

        return random;
    }

    public static T RemoveAndGetRandom<T>(this IList<T> list)
    {
        int index = Random.Range(0, list.Count);
        T item = list[index];
        list.RemoveAt(index);
        return item;
    }

    public static T GetClosestByPosition<T>(this IEnumerable<T> monoBehaviours, Vector3 relativePosition)
        where T : MonoBehaviour
    {
        float minimalDistance = float.MaxValue;
        T current = null;

        foreach (var sittable in monoBehaviours)
        {
            float currentDistance = Vector3.Distance(sittable.transform.position, relativePosition);

            if (currentDistance <= minimalDistance)
            {
                minimalDistance = currentDistance;
                current = sittable;
            }
        }

        return current;
    }

    public static T GetClosestByPositionExcept<T>(this IEnumerable<T> monoBehaviours, Vector3 relativePosition,
        T ignored = null) where T : MonoBehaviour
    {
        float minimalDistance = float.MaxValue;
        T current = null;

        foreach (var sittable in monoBehaviours)
        {
            if (ignored && ignored == sittable)
                continue;

            float currentDistance = Vector3.Distance(sittable.transform.position, relativePosition);

            if (currentDistance <= minimalDistance)
            {
                minimalDistance = currentDistance;
                current = sittable;
            }
        }

        return current;
    }

    public static bool HasInRange<T>(this IEnumerable<T> collection, Vector3 relativePos, float range)
        where T : MonoBehaviour
    {
        return collection.Any(elem => Vector3.Distance(relativePos, elem.transform.position) <= range);
    }
}