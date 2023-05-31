using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolItem: MonoBehaviour
{
    public bool IsUsed { get; private set; } = false;

    public virtual void SetUsedItem() => IsUsed = true;

    public virtual void SetNotUsedItem() => IsUsed = false;
}
