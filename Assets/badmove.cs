﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badmove : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 10f*Time.deltaTime, 0);
    }
}
