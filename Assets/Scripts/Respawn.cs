using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;
    public GameObject MenuMorte;
    public GameObject scoreScreen;

    private void OnTriggerEnter(Collider other)
    {
        scoreScreen.SetActive(false);
        MenuMorte.SetActive(true);
        Time.timeScale = 0;
        
        
    }
    public void respawn()
    {
        Time.timeScale = 1;
        player.transform.position = respawnPoint.transform.position;
        MenuMorte.SetActive(false);
        scoreScreen.SetActive(true);
    }
}
