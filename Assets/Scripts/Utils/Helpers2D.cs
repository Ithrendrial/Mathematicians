using UnityEngine;

public static class Helper2D
{
    ## Vector Operations

    public static Vector2 GetRandomVector2(float minX, float maxX, float minY, float maxY)
    {
        return new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

    public static Vector2 GetVectorToTarget(Vector2 origin, Vector2 target)
    {
        return (target - origin).normalized;
    }

    ## Object Pooling

    public static GameObject GetPooledObject(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        GameObject obj = ObjectPool.Instance.GetPooledObject(prefab);
        obj.transform.position = position;
        obj.transform.rotation = rotation;
        obj.SetActive(true);
        return obj;
    }

    ## Collision Detection

    public static bool IsOverlapping(Collider2D collider1, Collider2D collider2)
    {
        return collider1.bounds.Intersects(collider2.bounds);
    }

    public static Collider2D[] GetOverlappingColliders(Collider2D collider, LayerMask layerMask)
    {
        return Physics2D.OverlapAreaAll(collider.bounds.min, collider.bounds.max, layerMask);
    }

    ## Math Helpers

    public static float GetAngleFromVector(Vector2 vector)
    {
        return Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
    }

    public static Vector2 GetVectorFromAngle(float angle)
    {
        return new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));
    }

    ## Misc Utilities

    public static void DestroyChildren(Transform parent)
    {
        foreach (Transform child in parent)
        {
            GameObject.Destroy(child.gameObject);
        }
    }

    public static T GetRandomElement<T>(T[] array)
    {
        return array[Random.Range(0, array.Length)];
    }
}
