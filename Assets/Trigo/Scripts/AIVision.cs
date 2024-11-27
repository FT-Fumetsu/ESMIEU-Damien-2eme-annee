using UnityEngine;

public class AIVision : MonoBehaviour
{
    [Header("Vision Settings")]
    [SerializeField, Range(0f, 1f)] private float _visionLimit = 0.5f;

    [SerializeField] private GameObject _targetGameObject;
    [SerializeField] private GameObject _self;
    [SerializeField] private Color _seeTarget;
    [SerializeField] private Color _dontSeeTarget;

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(_self.transform.position, 1);

        Vector3 directionToTarget = (_targetGameObject.transform.position - transform.position).normalized;
        Vector3 rightVector = transform.right;
        float dotProduct = Vector3.Dot(rightVector, directionToTarget);
        if (dotProduct >= _visionLimit)
        {
            Gizmos.color = _seeTarget;
        }
        else
        {
            Gizmos.color = _dontSeeTarget;
        }
    }
}