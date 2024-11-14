using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerShoot : MonoBehaviour
    {
        [SerializeField] private float _timeBeforeShoot = 0.5f;
        [SerializeField] private float _chrono = 0;
        [SerializeField] private GameObject _bullet;
        [SerializeField] private Transform _bulletSpawnPosition;
        [SerializeField] private PlayerMovement _player;

        void Update()
        {
            _bulletSpawnPosition = _player.transform;
            _chrono += Time.deltaTime;
        }

        public void Shoot(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                if (_chrono >= _timeBeforeShoot)
                {
                    Instantiate(_bullet, _bulletSpawnPosition);
                    _chrono = 0f;
                }
            }
        }
    }
}