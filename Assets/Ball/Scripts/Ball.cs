using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float velocity = 1.0f;
    private Rigidbody2D _rigidbody;
    private int _score;
    public Action BallColidedWithGoalAction;
    public Action BallIntersectsWithGap;
    
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        BallColidedWithGoalAction?.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        BallIntersectsWithGap?.Invoke();
    }
}
