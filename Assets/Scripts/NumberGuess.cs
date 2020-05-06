using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGuess : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max = max + 1;
    }

    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}
