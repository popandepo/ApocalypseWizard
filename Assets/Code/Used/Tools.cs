using System.Collections.Generic;
using UnityEngine;

public static class Tools
{
    public static void TurnTowardsPoint(Transform transform, Vector3 point, float rotationSpeed)
    {
        Vector2 direction = point - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }


    public static List<GameObject> GetClosestGameObjects(GameObject start, GameObject target, int amount)
    {

        List<GameObject> matches = GetGameObjects(target);
        List<GameObject> output = new List<GameObject>();

        for (int i = 0; i < amount; i++)
        {

            GameObject match = matches[0];

            foreach (var item in matches)
            {
                if (Vector2.Distance(start.transform.position, item.transform.position) < Vector2.Distance(start.transform.position, match.transform.position))
                {
                    match = item;
                }
            }

            output.Add(match);
        }
        return output;
    }

    public static GameObject GetClosestGameObject(GameObject start, GameObject target)
    {
        List<GameObject> matches = GetGameObjects(target);
        GameObject output = matches[0];

        foreach (var item in matches)
        {
            if (Vector2.Distance(start.transform.position, item.transform.position) < Vector2.Distance(start.transform.position, output.transform.position))
            {
                output = item;
            }
        }

        return output;
    }

    public static List<GameObject> GetGameObjects(GameObject target)
    {
        List<GameObject> matches = new List<GameObject>();
        foreach (var gameObject in Controller.allObjects)
        {
            if (gameObject.gameObject == target)
            {
                matches.Add(gameObject);
            }
        }
        return matches;
    }

    public static float GetDistanceToObject(GameObject start, GameObject end)
    {
        return GetDistanceToPoint(start.transform.position, end.transform.position);
    }


    public static float GetDistanceToPoint(Vector3 start, Vector3 end)
    {
        return Vector3.Distance(start, end);
    }
}
