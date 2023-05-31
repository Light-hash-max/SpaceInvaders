using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextLevelController : MonoBehaviour
{
    [SerializeField]
    private GameObject _nextLevelView = default;
    [SerializeField]
    private Button _nextLevelButton = default;

    private void Awake()
    {
        _nextLevelButton.onClick.AddListener(ContinueGame);
        AllEnemiesController.onWin += ShowNextLevel;
    }

    private void OnDestroy()
    {
        _nextLevelButton.onClick.RemoveListener(ContinueGame);
        AllEnemiesController.onWin -= ShowNextLevel;
    }

    private void ShowNextLevel()
    {
        Time.timeScale = 0f;
        _nextLevelView.gameObject.SetActive(true);
    }

    private void ContinueGame()
    {
        Time.timeScale = 1f;
        _nextLevelView.gameObject.SetActive(false);
    }
}
