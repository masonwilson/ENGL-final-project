using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect2D : MonoBehaviour
{        
    public int coinValue = 1;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger");


        if (other.gameObject.CompareTag("Coins"))
        {
            Debug.Log("its a coin");
            Destroy(other.gameObject);
            CoinCounter.instance.ChangeScore(coinValue);
        }
    }

}
