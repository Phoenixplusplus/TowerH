using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Bouncer : MonoBehaviour {

    [Header("Bounce control Variables")]
    public float StartHeight = 10.0f;
    public float Gravity = -10.0f;

    private Vector3 Speed = new Vector3(0, 0, 0);


	// Use this for initialization
	void Start () {
        transform.position = new Vector3(transform.position.x, StartHeight, transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {
        Speed.y += Gravity * Time.fixedDeltaTime;
        transform.position += Speed * Time.fixedDeltaTime;

        if (transform.position.y <= 0.5 && Speed.y < 0)
        {
            Speed.y *= -1;
        }

	}
}
