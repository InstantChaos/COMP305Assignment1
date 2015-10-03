//Source File: ScrollingGround
//Author: Franco Chong
//Date Modified: September 23, 2015
//Program Description: Controls the program's background in order for it to move and scroll in one direction.


using UnityEngine;
using System.Collections;

public class ScrollingGround : MonoBehaviour {
	// public instanced variables

	//this will be used to determine the speed of the movement of the background
	public float speed; 
	
	// Use this for initialization
	void Start () {
		this.Reset ();
		
	}
	
	// Update is called once per frame
	void Update () {
		//gets the position of the background in order for it to move in a certain speed.
		Vector2 curPosition = new Vector2 (0.0f, 0.0f);
		curPosition = gameObject.GetComponent<Transform> ().position;
		curPosition.y -= speed;
		
		// the object is called to be moved
		gameObject.GetComponent<Transform> ().position = curPosition;
		
		// checks the boundary in order for it to reset
		if (curPosition.y <= -13) {
			this.Reset();
		}
	}
	
	// Resets the background to a certain position.
	private void Reset() {
		Vector2 resPosition = new Vector2 (0.0f, 6f);
		gameObject.GetComponent<Transform> ().position = resPosition;
	}
}
