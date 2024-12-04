using UnityEngine;

public class CoordinateTransformer : MonoBehaviour
{
    public Vector3 LocalToWorld(Vector3 localPoint)
    {
        Vector3 localRight = transform.right;
        Vector3 localUp = transform.up;
        Vector3 localForward = Vector3.Cross(localRight, localUp);

        Vector3 globalOrigin = transform.position;

        Vector3 globalPoint =
            globalOrigin +
            localPoint.x * localRight +
            localPoint.y * localUp +
            localPoint.z * localForward;

        return globalPoint;
    }

    public Vector3 WorldToLocal(Vector3 globalPoint)
    {
        Vector3 localRight = transform.right;
        Vector3 localUp = transform.up;
        Vector3 localForward = Vector3.Cross(localRight, localUp);

        Vector3 globalOrigin = transform.position;

        Vector3 offset = globalPoint - globalOrigin;

        float localX = Vector3.Dot(offset, localRight);
        float localY = Vector3.Dot(offset, localUp);
        float localZ = Vector3.Dot(offset, localForward);

        return new Vector3(localX, localY, localZ);
    }
}
