using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveInput;
    private float speed = 20f;
    float dirX;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        dirX = Input.acceleration.x * speed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.51f, 2.51f), transform.position.y);
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}
