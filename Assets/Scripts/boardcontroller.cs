using UnityEngine;
using System.Collections;

public class BoardController : MonoBehaviour {
	public float speed;
	public GUIText countText;
	public GUIText winText;



	private int count;

	void Start()
	{
		count = 0;	
		SetCountText();
		winText.text = "";
		
		
	}



	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}﻿


	void SetCountText()
	{
		countText.text = "Count " + count.ToString ();
		if (count >= 14) {
			winText.text = " CRUSHED IT!!!!!";
		}
	}

	void OnGUI()
	{
		
		//makes a GUI button at coordinates 10, 100, and a size of 200x40
		if(GUI.Button(new Rect (10,100,200,40),"Restart"))
		{
			//Loads a level
			Application.LoadLevel(Application.loadedLevel);
		}
	}

}

