using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;
    public doorScript ds;
    public int pontos;
    public int pontosPraGanhar;

    private void Start()
    {
        ds = GetComponent<doorScript>();
    }
    void Update()
    {
        scoreText.GetComponent<Text>().text = "moedas: " + theScore + " / " + pontosPraGanhar;
        pontos = theScore;
    }

    public void ResetPoints()
    {
        theScore = 0;
            pontos = 0;
    }
}
