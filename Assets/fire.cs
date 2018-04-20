using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour {
    public GameObject Bullet;
    public Transform target;
    public float Shoot;
    void Start () {
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, (this.gameObject.transform.position + new Vector3(Shoot, 0f, 0f)), this.gameObject.transform.rotation);
        }
	}
}
