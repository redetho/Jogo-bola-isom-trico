using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectJewel : MonoBehaviour
{
    public GameObject mola;
    public Player p;
    public AudioSource collectSound;
    private void Start()
    {
        GameObject g = GameObject.FindGameObjectWithTag("Player");
        p = g.GetComponent<Player>();
    }
    private void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        p.hasPower = true;
        mola.SetActive(true);
        Destroy(gameObject);
    }
}
