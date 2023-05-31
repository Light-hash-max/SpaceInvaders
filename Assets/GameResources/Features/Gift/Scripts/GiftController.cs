using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftController : BulletsPool
{
    [SerializeField]
    private float _probability = 1f;
    [SerializeField]
    private GiftInfo[] _giftInfos = default;

    private PoolItem _gift = default;
    private Transform _startTransform = default;

    protected override void Awake()
    {
        base.Awake();
        EnemyDamage.onDamage += SendGift;
    }

    private void OnDestroy()
    {
        EnemyDamage.onDamage -= SendGift;
    }

    public void SendGift(Transform startTransform)
    {
        _startTransform = startTransform;
        if (Random.Range(0f, 1f) <= _probability)
        {
            Fire();
        }
    }

    protected override void Fire()
    {
        _gift = GetObjectFromPool();
        _gift.transform.SetParent(_poolParent);
        _gift.transform.position = _startTransform.position;
        _gift.transform.rotation = _startTransform.rotation;
        _gift.GetComponent<GiftItem>().SetGift(_giftInfos[Random.Range(0, _giftInfos.Length)]);
        _gift.SetUsedItem();
    }
}
