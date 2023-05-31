using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameController : MonoBehaviour
{
    [SerializeField]
    private GameObject _endGameView = default;
    [SerializeField]
    private Button _button = default;
    [SerializeField]
    private ScoreCount _scoreCount = default;

    private void Awake()
    {
        EnemyTouchController.onEnemyTouch += EndGame;
        PlayerDamage.onPlayerDamage += EndGame;
        _button.onClick.AddListener(RestartGame);
    }

    private void OnDestroy()
    {
        EnemyTouchController.onEnemyTouch -= EndGame;
        PlayerDamage.onPlayerDamage -= EndGame;
        _button.onClick.RemoveListener(RestartGame);
    }

    private void EndGame()
    {
        Time.timeScale = 0;
        _endGameView.SetActive(true);
        _scoreCount.ResetScore();
    }

    private void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
