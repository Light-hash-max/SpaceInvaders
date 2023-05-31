using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public static event Action onPlayerDamage = delegate { };

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<EnemyBullet>(out EnemyBullet enemyBullet))
        {
            onPlayerDamage();
        }
    }
}
