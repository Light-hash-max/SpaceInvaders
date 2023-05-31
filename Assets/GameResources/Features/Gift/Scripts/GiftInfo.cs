using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GiftInfo", menuName = "Space/GiftInfo")]
public class GiftInfo : ScriptableObject
{
    [field: SerializeField]
    public GameObject Prefab { get; private set; } = default;

    [field: SerializeField]
    public GameObject Bullet = default;
}
