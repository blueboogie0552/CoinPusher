using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    public int scoreCount;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        this.scoreCount = 50;
        this.scoreText = this.GetComponent<Text>();
        this.scoreText.text = this.scoreCount.ToString();
    }

    public void AddScore()
    {
        this.scoreCount++;
        this.scoreText.text = this.scoreCount.ToString();
    }

    public void SubScore()
    {
        this.scoreCount--;
        this.scoreText.text = this.scoreCount.ToString();
    }
    
    public bool IsEmpty()
    {
        return this.scoreCount <= 0;
    }
}
