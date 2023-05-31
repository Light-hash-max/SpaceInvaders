using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsPool : PoolController
{
    protected Transform _poolParent = default;

    protected PoolItem _currentBullet = default;

    protected virtual void Awake()
    {
        _poolParent = FindObjectOfType<PoolParent>().transform;
    }

    protected virtual void Fire()
    {
        _currentBullet = GetObjectFromPool();
        _currentBullet.transform.SetParent(_poolParent);
        _currentBullet.transform.position = transform.position;
        _currentBullet.transform.rotation = transform.rotation;
        _currentBullet.SetUsedItem();
    }
}
