using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TMP_Text scoreText;

    private void OnEnable()
    {
        ScoreManager.ScoreChanged += UpdateScore;
        UpdateScore(scoreManager.CurrentScore);
    }

    private void OnDisable()
    {
        ScoreManager.ScoreChanged -= UpdateScore;
    }

    private void UpdateScore(int score)
    {
        scoreText.text = $"Score: {score}";
    }
}
