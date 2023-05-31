using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreCount", menuName = "Space/ScoreCount")]
public class ScoreCount : ScriptableObject
{
    public event Action onValueChange = delegate { };

    public int Count
    {
        get => PlayerPrefs.GetInt(nameof(ScoreCount), 0);

        private set
        {
            PlayerPrefs.SetInt(nameof(ScoreCount), value);
            PlayerPrefs.Save();

            onValueChange();
        }
    }

    public void AddCount(int addValue) => Count += addValue;

    public void ResetScore() => Count = 0;
}
