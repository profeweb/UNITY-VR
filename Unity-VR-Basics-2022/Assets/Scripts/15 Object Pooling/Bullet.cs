using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    /*
    public float speed;
    private ObjectPool<Bullet> _pool;
    private Rigidbody _rigidbody;
    private float timeUntilDestruction = 5f;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        ApplyVelocity();
    }

    void Update()
    {
        if (timeUntilDestruction > 0f)
        {
            timeUntilDestruction = TimeoutException.deltaTime;
        }
        else
        {
            DestroyBullet();
        }
    }

    public void setPool(ObjectPool<Bullet> pool)
    {
        _pool = pool;
    }

    private void ApplyVelocity()
    {
        _rigidbody.velocity = speed * transform.forward;
    }

    private void DestroyBullet()
    {
        if (_pool != null)
        {
            _pool.Release(this);
        }
        else
        {
            DestroyBullet(gameObject);
        }
    }
    */
}
