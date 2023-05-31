using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftItem : Bullet
{
    private GameObject _giftPrefab = default;

    public GiftInfo GiftInfo { get; private set; } = default;

    public void SetGift(GiftInfo giftInfo)
    {
        GiftInfo = giftInfo;
    }

    public override void SetNotUsedItem()
    {
        base.SetNotUsedItem();

        if (_giftPrefab != null)
        {
            Destroy(_giftPrefab);
            _giftPrefab = null;
        }
    }

    public override void SetUsedItem()
    {
        base.SetUsedItem();
        _giftPrefab = Instantiate(GiftInfo.Prefab, transform);
    }
}
