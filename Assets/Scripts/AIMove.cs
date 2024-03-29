﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    private Vector3 _walkUpLimit;
    private Vector3 _walkDownLimit;

    private Vector3 _direction;
    private Rigidbody2D _Rigidbody2D;
    public float speed;
    private Vector2 _toDestination;

    // Start is called before the first frame update
    void Start()
    {
        var diffPos = new Vector3(1.5f, 0, 0);
        _walkUpLimit = GameObject.Find("AI_Walk_Route_Up").transform.position + diffPos;
        _walkDownLimit = GameObject.Find("AI_Walk_Route_Down").transform.position + diffPos;

        _direction = _walkUpLimit;

        _Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _toDestination = _direction - transform.position;
        _Rigidbody2D.AddForce(_toDestination.normalized * speed * Time.deltaTime);
        Debug.Log(_toDestination.sqrMagnitude);

        if (_toDestination.sqrMagnitude <= 1)
		{
            _Rigidbody2D.velocity = new Vector2(0, 0);

            if (_direction == _walkUpLimit)
			{
                _direction = _walkDownLimit;
			}
			else
			{
                _direction = _walkUpLimit;
            }
		}
    }
}
