using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private Color _startingColor;
    [SerializeField] private Color _finalColor;
    [SerializeField] private Transform _centerCircle;
    [SerializeField] private Transform _otherPoint;
    [SerializeField, Range (0,10)] private float _circleRadius;

    private void DrawCircle()
    {
        Gizmos.color = _color;  
        Gizmos.DrawSphere(_centerCircle.position, _circleRadius);

        Vector3 vectorCenterOtherPoint = _otherPoint.position - _centerCircle.position;
        float sqrVector = vectorCenterOtherPoint.sqrMagnitude;

        if (sqrVector <= _circleRadius * _circleRadius)
        {
            _color = _finalColor;
        }

        else if (sqrVector > _circleRadius * _circleRadius)
        {
            _color = _startingColor;
        }
    }

    private void OnDrawGizmos()
    {
        DrawCircle();
    }
}
