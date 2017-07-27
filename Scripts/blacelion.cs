using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blacelion : MonoBehaviour {

	private Transform player;
	public GameObject protagonist;

	// Use this for initialization
	void Start () {
		player = protagonist.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 playerpos = player.position;
		playerpos.z = transform.position.z;
		transform.position = playerpos;
	}
}
