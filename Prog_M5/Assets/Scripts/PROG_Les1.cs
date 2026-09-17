using UnityEngine;

public class PROG_Les1 : MonoBehaviour
{
    string playerName = "Alysha";
    int score = 1000;
    bool alive = true;
    void Start()
    {
        Debug.Log("Name: " + playerName);
        Debug.Log("Score: "+ score);
        Debug.Log("Alive: "+ alive);
    }
}
