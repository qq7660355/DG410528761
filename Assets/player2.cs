using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {
    public float speed;
    public float rotationSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float rotation = Input.GetAxis("Horizontal") * speed*Time.deltaTime;
        float translation = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        //新的座標

        transform.Translate(0, 0, translation); //沿着Z轴移动
        transform.Rotate(0, rotation, 0); //绕Y轴旋转

    }
}
