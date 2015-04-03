using UnityEngine;
using System.Collections;


public class BoardController1 : MonoBehaviour {


	public float moveSpeed = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Rotate(Vector3.right * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.DownArrow))
			transform.Rotate(Vector3.left * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate(Vector3.down * moveSpeed * Time.deltaTime);
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate(Vector3.up * moveSpeed * Time.deltaTime);


	}﻿
}
