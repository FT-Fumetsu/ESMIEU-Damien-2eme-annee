using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private Color _startingColor;
    [SerializeField] private Color _pointColor;
    [SerializeField] private Color _gizmoColor;
    [SerializeField] private Color _hollowPurple;
    [SerializeField] private Transform _otherPoint;
    [SerializeField] private Circle _otherCircle;
    [SerializeField] private Transform _otherCenter;
    [SerializeField] private Transform _centerCircle;
    [SerializeField, Range (0, 10)] public float _circleRadius;

    public float Radius => _circleRadius;

    private void DrawCircle()
    {
        Gizmos.color = _color;  
        Gizmos.DrawSphere(_centerCircle.position, _circleRadius);

        ChangeColorOnCollidePoint();

        ChangeColorOnCollideGizmo();
    }

    private void OnDrawGizmos()
    {
        DrawCircle();
    }

    private void ChangeColorOnCollidePoint()
    {
        Vector3 vectorCenterOtherPoint = _otherPoint.position - _centerCircle.position;
        float sqrVectorCenterPoint = vectorCenterOtherPoint.sqrMagnitude;

        //Debug.Log(sqrVectorCenterPoint + " + " + _circleRadius * _circleRadius);

        if (sqrVectorCenterPoint <= _circleRadius * _circleRadius)
        {
            _color = _pointColor;
        }

        else if (sqrVectorCenterPoint > _circleRadius * _circleRadius)
        {
            _color = _startingColor;
        }
    }

    private void ChangeColorOnCollideGizmo()
    {
        Vector3 vectorCenterOtherGizmo = _otherCenter.position - _centerCircle.position;
        float sqrVectorCenterGizmo = vectorCenterOtherGizmo.sqrMagnitude;

        //Debug.Log(_circleRadius + _otherCircle.Radius);

        if (sqrVectorCenterGizmo <= (_circleRadius + _otherCircle.Radius) * (_circleRadius + _otherCircle.Radius))
        {
            _color = _gizmoColor;
        }

        else if (sqrVectorCenterGizmo > (_circleRadius + _otherCircle.Radius) * (_circleRadius + _otherCircle.Radius))
        {
            _color = _startingColor;
        }
    }

    //private void ChangeColorOnCollidePointMathf()
    //{
    //    Vector3 vectorCenterOtherPoint = _otherPoint.position - _centerCircle.position;
    //    float sqrVectorCenterPoint = Mathf.Sqrt((vectorCenterOtherPoint.x * vectorCenterOtherPoint.x) + (vectorCenterOtherPoint.y * vectorCenterOtherPoint.y));
    //    Debug.Log(sqrVectorCenterPoint + " + " + _circleRadius);

    //    if (sqrVectorCenterPoint <= _circleRadius)
    //    {
    //        _color = _pointColor;
    //    }

    //    else if (sqrVectorCenterPoint > _circleRadius)
    //    {
    //        _color = _startingColor;
    //    }
    //}

    //private void ChangeColorOnCollideGizmoMathf()
    //{
    //    Vector3 vectorCenterOtherGizmo = _otherCenter.position - _centerCircle.position;
    //    float sqrVectorCenterGizmo = Mathf.Sqrt((vectorCenterOtherGizmo.x * vectorCenterOtherGizmo.x) + (vectorCenterOtherGizmo.y * vectorCenterOtherGizmo.y));

    //    //Debug.Log(_circleRadius + _otherCircle.Radius);

    //    if (sqrVectorCenterGizmo <= _circleRadius + _otherCircle.Radius)
    //    {
    //        _color = _gizmoColor;
    //    }

    //    else if (sqrVectorCenterGizmo > _circleRadius + _otherCircle.Radius)
    //    {
    //        _color = _startingColor;
    //    }
    //}
}
