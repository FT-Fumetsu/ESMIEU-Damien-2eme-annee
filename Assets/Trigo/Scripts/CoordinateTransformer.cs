using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace Coordinates
{
    public class CoordinateTransformer : MonoBehaviour
    {
        [SerializeField] private bool _localCoordonatesBool;
        [SerializeField] private GameObject _gameObjectReference;


        private void OnDrawGizmos()
        {
            Vector2 worldPoint = _gameObjectReference.transform.position;
            Vector2 localCoordinates = WorldToLocal(worldPoint);

            Vector2 worldCoordinates = LocalToWorld(localCoordinates);

            if (_localCoordonatesBool)
            {
                Debug.Log("Local Coordonates : " + localCoordinates);
            }
            else
            {
                Debug.Log("World Coordonates : " + worldCoordinates);
            }
        }
        public Vector2 LocalToWorld(Vector2 localPoint)
        {
            Vector2 localRight = transform.right;
            Vector2 localUp = transform.up;

            Vector2 globalOrigin = transform.position;

            Vector2 globalPoint =
                globalOrigin +
                localPoint.x * localRight +
                localPoint.y * localUp;

            return globalPoint;
        }

        public Vector2 WorldToLocal(Vector2 globalPoint)
        {
            Vector2 localRight = transform.right;
            Vector2 localUp = transform.up;

            Vector2 globalOrigin = transform.position;

            Vector2 offset = globalOrigin - globalPoint;

            float localX = Vector2.Dot(offset, localRight);
            float localY = Vector2.Dot(offset, localUp);

            return new Vector3(localX, localY);
        }
    }
}