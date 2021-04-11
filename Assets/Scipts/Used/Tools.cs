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
}
