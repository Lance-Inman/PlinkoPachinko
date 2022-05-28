using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegMotionController : MonoBehaviour
{
    private float vertMax;
    public float verticalSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        vertMax = Camera.main.GetComponent<Camera>().orthographicSize; 
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector2(0, verticalSpeed) * Time.deltaTime, Space.Self);
        
        if (gameObject.transform.position.y > vertMax) 
        {
            Destroy(gameObject);
        }
    }
}
