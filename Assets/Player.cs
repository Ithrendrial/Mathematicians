using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEditor.Callbacks;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20.0f;
    public Vector2 direction;
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x_move = 0.0f;
        float y_move = 0.0f;

        if (Input.GetKey(KeyCode.W))
        {
            y_move = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            y_move = -1.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x_move = -1.0f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x_move = 1.0f;
        }

        direction = new Vector2(x_move, y_move).normalized;
        _rb.velocity = speed * direction * Time.deltaTime;
    }
}
