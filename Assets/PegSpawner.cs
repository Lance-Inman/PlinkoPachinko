using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegSpawner : MonoBehaviour
{
    public GameObject peg;
    private float minX;
    private float maxX;
    private float minY;
    private float maxY;
    // Start is called before the first frame update
    void Start()
    {
        float vertMax = Camera.main.GetComponent<Camera>().orthographicSize;    
        maxX = vertMax * Screen.width / Screen.height;
        minX = -maxX;
        maxY = -vertMax;
        minY = -vertMax * 2;

         //Instantiate(peg, new Vector2(horzExtent, vertExtent), Quaternion.identity);
         //Instantiate(peg, new Vector2(-horzExtent, -vertExtent), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.Range(1, 100) >= 99.0) {
            Instantiate(peg, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
        }
    }
}
