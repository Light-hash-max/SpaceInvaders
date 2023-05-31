using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : BulletsPool
{
    private const float DELTA_TIME = 2f;

    [SerializeField]
    private float _probability = 0.1f;

    private Coroutine _firingCoroutine = null;

    private void OnEnable()
    {
        if (_firingCoroutine != null)
        {
            StopCoroutine(_firingCoroutine);
            _firingCoroutine = null;
        }
        _firingCoroutine = StartCoroutine(Firing());
    }

    private IEnumerator Firing()
    {
        while (enabled)
        {
            yield return new WaitForSeconds(DELTA_TIME);
            if (Random.Range(0f, 1f) <= _probability)
            {
                Fire();
            }
        }
    }
}
