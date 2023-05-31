using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class EnemyItem : PoolItem
{
    public bool IsAlive { get; private set; } = true;

    [SerializeField]
    private GameObject _interaction = default;

    private CanvasGroup _canvasGroup = default;

    private AllEnemiesController _controller = default;

    private void Awake()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    public void SetController(AllEnemiesController controller)
    {
        _controller = controller;
    }

    public void Reanimate()
    {
        _canvasGroup.alpha = 1;
        _interaction.SetActive(true);
        IsAlive = true;
    }

    public void Kill()
    {
        _canvasGroup.alpha = 0;
        _interaction.SetActive(false);
        IsAlive = false;
        _controller.Kill(this);
    }
}
