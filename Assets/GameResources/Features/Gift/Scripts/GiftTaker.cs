using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiftTaker : MonoBehaviour
{
    [SerializeField]
    private FireGiftMode _fireGiftMode = default;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<GiftItem>(out GiftItem giftItem))
        {
            _fireGiftMode.ChangeFireMode(giftItem.GiftInfo);
            giftItem.SetNotUsedItem();
        }
    }
}
