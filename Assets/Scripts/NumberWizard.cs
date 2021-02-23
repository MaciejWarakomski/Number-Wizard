using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        GuessNumber();
    }

    void GuessNumber()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void OnPressHigher()
    {
        if (max > min)
        {
            min = guess + 1;
        }
        GuessNumber();
    }

    public void OnPressLower()
    {
        if (max > min)
        {
            max = guess - 1;
        }
        GuessNumber();
    }
}
