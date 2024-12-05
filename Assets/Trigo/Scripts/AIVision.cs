using System;
using UnityEditor;
using UnityEngine;

namespace IA
{
    public class AIVision : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField, Range(0, 10)] private float _circleRadius;
        [SerializeField, Range(0, 180)] private float _viewAngle;

        private void OnDrawGizmos()
        {
            Vector3 distance = _target.position - transform.position;

            if (distance.sqrMagnitude < _circleRadius * _circleRadius)
            {
                if (Vector3.Dot(distance.normalized, transform.right) <= (_viewAngle - 180) / 180)
                {
                    Handles.color = Color.green;
                }
            }

            Handles.DrawWireDisc(transform.position, transform.forward, _circleRadius);
        }
    }
}