using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : PoolItem
{
    [SerializeField]
    protected float _speed = 500;

    public override void SetUsedItem()
    {
        base.SetUsedItem();
        gameObject.SetActive(true);
    }

    public override void SetNotUsedItem()
    {
        base.SetNotUsedItem();
        gameObject.SetActive(false);
    }
    private void Update()
    {
        if (IsUsed)
        {
            transform.localPosition += transform.up * _speed * Time.deltaTime;
        }
    }
}
