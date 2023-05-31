using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolController : MonoBehaviour
{
    [SerializeField]
    protected PoolItem _poolItem = default;

    private PoolItem _newItem = default;

    protected List<PoolItem> _poolItems = new List<PoolItem>();

    public PoolItem GetObjectFromPool()
    {
        foreach (PoolItem poolItem in _poolItems)
        {
            if (!poolItem.IsUsed)
            {
                return poolItem;
            }
        }

        _newItem = Instantiate(_poolItem);
        _poolItems.Add(_newItem);
        return _newItem;
    }
}
