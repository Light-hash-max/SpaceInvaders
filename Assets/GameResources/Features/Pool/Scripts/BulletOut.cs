using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletOut : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Bullet>(out Bullet bullet))
        {
            bullet.SetNotUsedItem();
        }
    }
}
