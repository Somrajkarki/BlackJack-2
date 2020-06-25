using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovementTest : MonoBehaviour
{
    new private Rigidbody2D rigidbody;
    private float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 v = rigidbody.velocity;
        v.x = speed;
        rigidbody.velocity = v;
    }
}
