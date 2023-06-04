using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGiftMode : MonoBehaviour
{
    [SerializeField]
    private GameObject _defaultMode = default;

    private GiftInfo _currentGift = default;
    private GameObject _currentFireMode = default;

    private Dictionary<GiftInfo, GameObject> _fireGiftsDictionary = new Dictionary<GiftInfo, GameObject>();

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
            else
            {
                _fireGiftsDictionary[_currentGift].SetActive(false);

                if (_fireGiftsDictionary.TryGetValue(giftInfo, out _currentFireMode))
                {
                    _currentGift = giftInfo;
                    _currentFireMode.SetActive(true);
                    return;
                }
            }
        }

        _currentGift = giftInfo;
        _currentFireMode = Instantiate(giftInfo.Bullet, transform);
        _fireGiftsDictionary.Add(giftInfo, _currentFireMode);

    }
}
