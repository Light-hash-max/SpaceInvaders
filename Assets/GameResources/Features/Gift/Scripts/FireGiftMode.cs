using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGiftMode : MonoBehaviour
{
    [SerializeField]
    private GameObject _defaultMode = default;

    private GiftInfo _currentGift = default;
    private GameObject _currentFireMode = default;

    public void ChangeFireMode(GiftInfo giftInfo)
    {
        if (_defaultMode.activeSelf)
        {
            _defaultMode.SetActive(false);
        }

        if (_currentGift != null)
        {
            if (_currentGift == giftInfo)
            {
                return;
            }
        }

        Destroy(_currentFireMode);
        _currentFireMode = Instantiate(giftInfo.Bullet, transform);

    }
}
