using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscript : MonoBehaviour {

    Rigidbody rigidbody;
    const float WalkSpeed = 20.0f;

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {

        Vector3 velocity = Vector3.zero;
        float speed = WalkSpeed;

        if (Input.GetKey(KeyCode.W))
        {
            velocity.z += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            velocity.z -= speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += speed;
        }

        rigidbody.velocity = transform.TransformVector(velocity);

    }
}
