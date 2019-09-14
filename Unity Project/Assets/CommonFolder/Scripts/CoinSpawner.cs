using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinPrefab;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject coinCounter = GameObject.Find("CoinCounter");
            if (!coinCounter.GetComponent<CoinCounter>().IsEmpty())
            {
                coinCounter.GetComponent<CoinCounter>().SubScore();
                Vector3 clickPosition = Input.mousePosition;
                clickPosition.z += 12f;
                Vector3 worldPoint = Camera.main.ScreenToWorldPoint(clickPosition);
                Instantiate(this.CoinPrefab, worldPoint, Quaternion.identity);
            }
        }
    }
}
