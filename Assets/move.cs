﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float speed;
    public float destime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //this.gameObject.transform.position += new Vector3(speed, 0f, 0f);
        Destroy(gameObject, destime);
	}
}
