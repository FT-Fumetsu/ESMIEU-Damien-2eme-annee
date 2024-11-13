using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _bulletSpeed = 5f;
    [SerializeField] private Rigidbody2D _rigidbody;

    void Update()
    {
        _rigidbody.velocity = new Vector2(0, _bulletSpeed);
    }
}