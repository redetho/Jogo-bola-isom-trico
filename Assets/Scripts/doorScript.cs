using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorScript : MonoBehaviour
{
    public int cena = 0;
    public ScoringSystem ss;
    public int pontosPraGanhar;

    private void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (ss.pontos == pontosPraGanhar)
        {
            SceneManager.LoadScene(cena + 1);
            ss.ResetPoints();
        }
    }
}
