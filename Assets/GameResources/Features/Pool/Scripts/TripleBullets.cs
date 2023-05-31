using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleBullets : PlayerBullets
{
    protected override void Fire()
    {
        SetBullet(transform.rotation);

        SetBullet(transform.rotation);
        _currentBullet.transform.Rotate(transform.eulerAngles + Vector3.forward * 10);

        SetBullet(transform.rotation);
        _currentBullet.transform.Rotate(transform.eulerAngles + Vector3.back * 10);
    }

    private void SetBullet(Quaternion rotation)
    {
        _currentBullet = GetObjectFromPool();
        _currentBullet.transform.SetParent(_poolParent);
        _currentBullet.transform.position = transform.position;
        _currentBullet.transform.rotation = transform.rotation;
        _currentBullet.SetUsedItem();
    }
}
