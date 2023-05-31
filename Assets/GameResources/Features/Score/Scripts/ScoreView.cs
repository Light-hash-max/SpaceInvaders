using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreView : MonoBehaviour
{
    [SerializeField]
    private ScoreCount _scoreCount = default;

    private Text _text = default;

    private void Awake()
    {
        _text = GetComponent<Text>();
        _scoreCount.onValueChange += ChangeText;
        ChangeText();
    }

    private void OnDestroy() => _scoreCount.onValueChange -= ChangeText;

    private void ChangeText() => _text.text = _scoreCount.Count.ToString();
}
