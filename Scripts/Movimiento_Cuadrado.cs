﻿

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movimiento_Cuadrado : MonoBehaviour {

	public GameObject Suelo;
	public GameObject Bala;

	public float speed= 0.1f;
	public string cderecha = "d";
	public string cizquierda = "a";
	public string carriba = "w";
	public string cabajo = "s";
	public string cconsola = "p";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		var posicion = GameObject.Find ("Cuadrado");



		// Movimiento 


		if (Input.GetKey(KeyCode.Mouse0)){
			var cuadrado = GameObject.Find ("Cuadrado");
			Vector3 newPosition = cuadrado.transform.position + (Vector3.down * 10);
			Instantiate (Bala, posicion.transform.position, Quaternion.identity);
		}
		if (Input.GetKey (cderecha)){
		transform.Translate(speed, 0f, 0f);
		}
		if (Input.GetKey (cizquierda)) {
			transform.Translate (-speed, 0f, 0f);
		}
		if (Input.GetKeyDown (carriba)){
			speed += 0.1f;
		}
		if (Input.GetKeyDown (cabajo)) {
			if (speed >= 0.1f) {
				speed += -0.1f;
			}
		}
		if (Input.GetKey (cconsola)) {
			print (speed);
		}
			

		// Límites

		float newX = Mathf.Clamp (transform.position.x, -12.5f, 12.5f);
		float newY = Mathf.Clamp (transform.position.y, -10, 10);
		transform.position = new Vector3 (newX, newY, transform.position.z);
	}
}
