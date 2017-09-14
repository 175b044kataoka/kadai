using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {
    public float speed = 3.0f;
    Rigidbody rb;
    public int moveSpeed = 1;
    // Use this for initialization
    void Start()
    {
    rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("down"))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        rb.velocity = new Vector3(moveSpeed, rb.velocity.y);
    }
}
