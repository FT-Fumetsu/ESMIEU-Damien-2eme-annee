using UnityEngine;

namespace Bullet
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _bulletSpeed = 5f;
        [SerializeField] private Rigidbody2D _rigidbody;
        [SerializeField] private float _chrono;
        [SerializeField] private float _timeBeforeBulletDies = 4f;

        void Update()
        {
            _rigidbody.velocity = new Vector2(0, _bulletSpeed);
            _chrono += Time.deltaTime;

            if (_chrono >= _timeBeforeBulletDies)
            {
                _chrono = 0;
                Destroy(gameObject);
                Debug.Log("Destroy Bullet");
            }
        }
    }
}