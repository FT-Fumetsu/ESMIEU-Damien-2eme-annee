
using UnityEngine;
using UnityEngine.InputSystem;
using Player;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private float _timeBeforeShoot = 0f;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _bulletSpawnPosition;
    [SerializeField] private PlayerMovement _player;

    void Update()
    {
        _bulletSpawnPosition = _player.transform;

        _timeBeforeShoot += Time.deltaTime;
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if(_timeBeforeShoot >= .5f)
            {
                Instantiate(_bullet, _bulletSpawnPosition);
                _timeBeforeShoot = 0f;
            }
        }
    }
}