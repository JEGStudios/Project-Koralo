using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movement_script : MonoBehaviour {
	
	//Variables velocidad
	public float speed = 0.1;
	public float nspeed = -0.1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey ("d")) //Checks if the "d" button is pressed
        {
            Flip("right");
            transform.Translate(speed, 0f, 0f);
        }
        if(Input.GetKey ("a")) //Checks if the "a" button is pressed
        {
            Flip("left");
            transform.Translate(nspeed, 0f, 0f);
        }
	}
    public void Flip(string direction) //Function flip
    {
        var thescale = transform.localScale;
        if (direction == "right") //If direction = right the sprite resets to its normal state
        {
            thescale.x = 0.297211f;
        }
        else
        {
            thescale.x = -0.297211f; //If direction isnt = to right the sprite flips
        }
        transform.localScale = thescale;
    }
}
