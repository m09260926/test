﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame

   

    public float y;

    void Update()
    {
        Transform transform = GetComponent<Transform>();
        Vector3 angle = new Vector3(0, y, 0);
        transform.Rotate(angle);
    }
}
