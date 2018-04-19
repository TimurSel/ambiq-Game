using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    // ms stands for movementSpeed
    float ms = 15f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        // ms stands for movementSpeed
        float xPos = h * (ms + 90) * Time.deltaTime;
        float zPos = z * ms * Time.deltaTime;

        transform.Translate(0, 0, zPos);
        transform.Rotate(0, xPos, 0);
    }
}