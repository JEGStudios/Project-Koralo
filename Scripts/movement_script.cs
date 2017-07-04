﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement_script : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey ("d"))
        {
            Flip("right");
            transform.Translate(0.1f, 0f, 0f);
        }
        if(Input.GetKey ("a"))
        {
            Flip("left");
            transform.Translate(-0.1f, 0f, 0f);
        }
	}
    public void Flip(string direction)
    {
        var thescale = transform.localScale;
        if (direction == "right")
        {
            thescale.x = 0.297211f;
        }
        else
        {
            thescale.x = -0.297211f;
        }
        transform.localScale = thescale;
    }
}
