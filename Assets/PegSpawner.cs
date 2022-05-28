using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegSpawner : MonoBehaviour
{
    public GameObject peg;
    [Range(0, 11)]
    public float spawnRate;
    public Spawnable spawn1;
    private float minX;
    private float maxX;
    private float minY;
    private float maxY;

    public class Spawnable
    {
        public GameObject spawnable;
        [Range(0, 11)]
        public float spawnRate;
    }

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
        if (Random.Range(0, 100) < spawnRate) {
            Instantiate(peg, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
        }
    }
}
