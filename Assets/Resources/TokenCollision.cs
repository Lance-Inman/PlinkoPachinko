﻿using UnityEngine;
using System.Collections;

public class TokenCollision : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Score.score += 1;
    }
}
