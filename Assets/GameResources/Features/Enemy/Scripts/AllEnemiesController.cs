using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllEnemiesController : PoolController
{
    public static event Action onWin = delegate { };

    [SerializeField]
    private int _enemyCount = 28;
    [SerializeField]
    private EnemyMovement _enemyMovement = default;

    private List<EnemyItem> _enemyItems = new List<EnemyItem>();

    private void Awake()
    {
        CreateEnemy();
    }

    private void CreateEnemy()
    {
        _enemyItems.Clear();

        for (int i = 0; i < _enemyCount; i++)
        {
            _enemyItems.Add(GetObjectFromPool().GetComponent<EnemyItem>());
            _poolItems[i].SetUsedItem();
            foreach (EnemyItem enemyItem in _enemyItems)
            {
                enemyItem.transform.SetParent(transform);
                enemyItem.SetController(this);
            }
        }
    }

    public void Kill(EnemyItem enemyItem)
    {
        foreach (EnemyItem item in _enemyItems)
        {
            if (item.IsAlive)
            {
                return;
            }
        }

        onWin();

        _enemyMovement.Restart();

        foreach (EnemyItem item in _enemyItems)
        {
            item.Reanimate();
        }
    }
}
