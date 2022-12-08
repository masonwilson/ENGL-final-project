using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CoinCollect2D : MonoBehaviour
{
    List<Vector3Int> trackedCells = new List<Vector3Int>();
    public Tilemap tilemap;
    public GridLayout gridLayout;

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
        }
    }

}
