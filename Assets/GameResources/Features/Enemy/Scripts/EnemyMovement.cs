using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField]
    private float _moveTime = 3f;
    [SerializeField]
    private float _moveDistance = 500f;
    [SerializeField]
    private float _moveDown = 50f;

    private Coroutine _movingCoroutine = null;
    private Vector3 _startPosition = default;

    private void Start()
    {
        _startPosition = transform.position;
        StartMove();
    }

    public void Restart()
    {
        if (_movingCoroutine != null)
        {
            StopCoroutine(_movingCoroutine);
            _movingCoroutine = null;
        }

        if (LeanTween.isTweening(gameObject))
        {
            LeanTween.cancel(gameObject);
        }

        transform.position = _startPosition;
        StartMove();
    }

    public void StartMove()
    {
        if (_movingCoroutine != null)
        {
            StopCoroutine(_movingCoroutine);
            _movingCoroutine = null;
        }
        _movingCoroutine = StartCoroutine(Moving());
    }

    private IEnumerator Moving()
    {
        while (enabled)
        {
            LeanTween.move(gameObject, transform.position + Vector3.right * _moveDistance, _moveTime);
            yield return new WaitForSeconds(_moveTime);
            transform.position += Vector3.down * _moveDown;
            LeanTween.move(gameObject, transform.position + Vector3.left * _moveDistance, _moveTime);
            yield return new WaitForSeconds(_moveTime);
            transform.position += Vector3.down * _moveDown;
        }
    }
}
