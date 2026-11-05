using System;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static event Action<int> ScoreChanged;

    public int CurrentScore { get; private set; }

    public void AddScore(int amount)
    {
        if (amount == 0)
            return;

        CurrentScore += amount;
        ScoreChanged?.Invoke(CurrentScore);
    }

    public void SetScore(int score)
    {
        if (CurrentScore == score)
            return;

        CurrentScore = score;
        ScoreChanged?.Invoke(CurrentScore);
    }
}
