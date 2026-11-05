using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private int points = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
            return;

        if (scoreManager == null)
        {
            Debug.LogError("ScorePickup needs a ScoreManager reference.", this);
            return;
        }

        scoreManager.AddScore(points);
        Destroy(gameObject);
    }
}
