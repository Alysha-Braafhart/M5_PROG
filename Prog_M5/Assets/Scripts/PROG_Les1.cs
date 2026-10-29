using System;
using UnityEngine;

public class PROG_Les1 : MonoBehaviour
{
    Speler speler;
    string playerName = "Alysha";
    int score = 1000;
    bool alive = true;
    int health = 100;
    int numbers;
    int nummers;
    int aanval;
    int verdediging;


    void Start()
    {
        // Begroeting(playerName);
        Max(numbers,numbers);
        BerekenSchade(aanval, verdediging);
        string[] Vijanden = new string[5] { "Orc", "Knight", "Wizard", "Ogre", "Dragon" };
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(Vijanden[i]);
        }

        int[] scores = new int[4] {10, 20 , 30, 60 };
        int hoogsteScore = scores[0];
        for(int i = 1; i < scores.Length; i++)
        {
            if(scores[i] > hoogsteScore)
            {
                hoogsteScore = scores[i];
            }
        }
        Debug.Log("Highest: " + hoogsteScore);
        
        Speler speler1 = new Speler();

        speler1.naam = "Mario";
        speler1.HP = 15;
        speler1.skore = 10;

        // Debug.Log("Player name: " + speler1.naam);
        // Debug.Log("Player HP: " + speler1.HP);
        // Debug.Log("Player score: " + speler1.skore);

        speler1.Vertel(speler1);

        Speler speler2 = new Speler();

        speler2.naam = "Wario";
        speler2.HP = 30;
        speler2.skore = 20;

        Debug.Log("Player name: " + speler2.naam);
        Debug.Log("Player HP: " + speler2.HP);
        Debug.Log("Player score: " + speler2.skore);
        
    }
    int Max(int a, int b)
    {
        a = 50;
        b = 141;
        if (a > b)
        {
            Debug.Log("Result: " + a);
            return a;
        }
        else
        {
            Debug.Log("Result: " + b);
            return b;
        }
      
    }

    int BerekenSchade(int aanval, int verdediging)
    {
        aanval = 50;
        verdediging = 10;
        Debug.Log ("Schade: " + (aanval - verdediging));
        return aanval - verdediging;
    }
    
    void Begroeting(string naam)
    {
        Debug.Log("Welcome " + naam + "!");   
        Debug.Log("Score: "+ score);
        Debug.Log("Alive: "+ alive);
        Debug.Log("HP: " + health);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            health -= 35;
            Debug.Log("HP: " + health);
            if(health > 0)
            {
                Debug.Log("Speler leeft nog!");
            }
        }

        if(health <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Speler is dood");
        }
    }
}

public class Speler
{
    public string naam;
    public int HP;
    public int skore;

    public void Vertel(Speler speler1)
    {
        Debug.Log("Ik ben [Naam], mijn HP is [HP] en mijn score is [Score].");
    }
}
  