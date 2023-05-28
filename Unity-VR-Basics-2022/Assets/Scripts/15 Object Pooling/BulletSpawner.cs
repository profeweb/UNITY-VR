using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class BulletSpawner : MonoBehaviour
{

    public bool useObjectPooling = false;
    public Bullet bulletPrefab;

    public int bulletActive;
    public int bulletInactive;

    private ObjectPool<Bullet> _bulletPool;
    private Bullet currentBullet;

    void Start()
    {
        _bulletPool = new ObjectPool<Bullet>(InstantiatePoolBullet, GetBulletFromPool, ReturnBalletToPool);
        InvokeRepeating(nameof(InstantiateBullets), .05f, .05f);
    }

    void Update()
    {
        bulletActive = _bulletPool.CountActive;
        bulletInactive = _bulletPool.CountInactive;
    }

    private Bullet InstantiatePoolBullet()
    {
        return InstantiatePoolBullet(bulletPrefab);
    }

    private void GetBulletFromPool(Bullet bullet)
    {
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;
        bullet.setPool(_bulletPool);
        bullet.gameObject.SetActive(true);
    }

    private void ReturnBalletToPool(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
    }

    private void InstantiateBullets()
    {
        if (useObjectPooling)
        {
            _currentBullet = _bulletPool.Get();
        }
        else
        {
            _currentBullet = InstantiatePoolBullet(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
