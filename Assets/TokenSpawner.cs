using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TokenSpawner : MonoBehaviour
{
    public GameObject token;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(token, new Vector2(0, 10), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
