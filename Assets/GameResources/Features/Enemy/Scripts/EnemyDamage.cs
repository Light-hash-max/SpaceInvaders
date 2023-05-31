using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public static event Action<Transform> onDamage = delegate { };

    [SerializeField]
    private ScoreCount _scoreCount = default;
    [SerializeField]
    private int _damagePoint = 1;
    [SerializeField]
    private EnemyItem _enemyItem = default;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerBullet>(out PlayerBullet playerBullet))
        {
            playerBullet.SetNotUsedItem();
            _scoreCount.AddCount(_damagePoint);
            onDamage(transform);
            _enemyItem.Kill();
        }
    }
}
