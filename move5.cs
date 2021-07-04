﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move5 : MonoBehaviour
{
	float dirX, moveSpeed = 4f;
	bool moveRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 22f)
        	moveRight = false;
        if (transform.position.x < 30f)
        	moveRight = true;

        	if (moveRight)
        		transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        	else
        		transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
