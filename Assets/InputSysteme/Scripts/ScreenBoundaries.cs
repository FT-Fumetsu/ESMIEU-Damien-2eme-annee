using UnityEngine;

namespace Boundaries
{
    public class ScreenBoundaries : MonoBehaviour
    {
        //private Vector2 _screenBounds;
        //private float _objectWidth;
        //private float _objectHeight;

        //private void Start()
        //{
        //    _screenBounds = Camera.main.ScreenToViewportPoint(new Vector2(Screen.width, Screen.height));
        //    _objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y;
        //    _objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
        //}

        //private void LateUpdate()
        //{
        //    Vector2 viewPos = transform.position;
        //    viewPos.x = Mathf.Clamp(viewPos.x, _screenBounds.x + _objectWidth, _screenBounds.x * - _objectWidth);
        //    viewPos.y = Mathf.Clamp(viewPos.y, _screenBounds.y + _objectHeight, _screenBounds.y * - _objectHeight);
        //    transform.position = viewPos;
        //}
    }
}