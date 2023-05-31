using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTouchController : MonoBehaviour
{
    public static event Action onEnemyTouch = delegate { };

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<EnemyBullets>(out EnemyBullets enemyBullets))
        {
            onEnemyTouch();
        }
    }
}
