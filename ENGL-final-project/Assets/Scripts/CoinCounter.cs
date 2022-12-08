using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public static CoinCounter instance;
    public TextMeshProUGUI text;
    int score;
    // Start is called before the first frame update
    void Start()
    { 
        if (instance == null)
        {
            instance = this;
        }
        
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        text.text = "Coins: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
