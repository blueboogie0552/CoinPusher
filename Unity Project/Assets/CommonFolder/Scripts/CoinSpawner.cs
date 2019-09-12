using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject CoinPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 clickPosition = Input.mousePosition;
            clickPosition.z += 12f;
            Vector3 worldPoint = Camera.main.ScreenToWorldPoint(clickPosition);
            Instantiate(this.CoinPrefab, worldPoint, Quaternion.identity);
        }

        if (this.CoinPrefab.transform.position.y < -10)
        {
            Destroy(this.CoinPrefab);
        }
    }
}
