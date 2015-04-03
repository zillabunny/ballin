using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
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
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Debug.Log (moveHorizontal);
		Debug.Log (moveVertical);

		//Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		//Debug.Log (movement);
		
		//GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
	}﻿

	void OnTriggerEnter(Collider other) 
	{
		if ( other.gameObject.tag =="PickUp")
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText();
		}
	}

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

//Destroy(other.gameObject);
//gameObject.tag = "player";
//gameObject.SetActive(false);
