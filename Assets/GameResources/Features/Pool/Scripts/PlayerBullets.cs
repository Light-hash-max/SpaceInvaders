using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : BulletsPool
{
    [SerializeField]
    private float _frequency = 1f;

    private float _currentTime = 0f;

    protected virtual void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _frequency)
        {
            Fire();
           _currentTime = 0f;
        }
    }
}