using UnityEngine;

public class TestCoordinateTransformer : MonoBehaviour
{
    [SerializeField] private CoordinateTransformer transformer;
    [SerializeField] private Vector3 localPoint;
    [SerializeField] private Vector3 worldPoint;

    void Start()
    {
        Vector3 convertedToWorld = transformer.LocalToWorld(localPoint);
        Debug.Log($"Le point local {localPoint} converti en global : {convertedToWorld}");

        Vector3 convertedToLocal = transformer.WorldToLocal(worldPoint);
        Debug.Log($"Le point global {worldPoint} converti en local : {convertedToLocal}");
    }
}
