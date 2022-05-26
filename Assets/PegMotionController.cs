using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegMotionController : MonoBehaviour
{
    public float verticalSpeed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, verticalSpeed) * Time.deltaTime, Space.Self);
    }
}
