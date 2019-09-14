using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public AudioClip getCoinSE;
    public AudioSource aud;
    void Start()
    {
        this.aud = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject CoinCounter = GameObject.Find("CoinCounter");
        CoinCounter.GetComponent<CoinCounter>().AddScore();
        this.aud.PlayOneShot(this.getCoinSE);
        Destroy(other.gameObject);
    }
}
