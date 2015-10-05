//Source File: PickUp Controller
//Author: Franco Chong
//Date Modified: October 5, 2015
//Program Description: Controls the item pick up position and speed.


using UnityEngine;
using System.Collections;


public class PickUpController : MonoBehaviour {
	// public variables
	public Speed speed;
	public Boundary boundary;
	
	//private variables
	private float curSpeed;
	
	// Use this for initialization
	void Start () {
		this.Reset ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;		 
		currentPosition.y -= this.curSpeed;
		
		// move to the current position
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		// checks the boundary.
		if (currentPosition.y <= boundary.yMin) {
			this.Reset();
		}
	}
	
	// Resets the gameObject
	private void Reset() {
		this.curSpeed = Random.Range (speed.minSpeed, speed.maxSpeed);
		Vector2 resetPosition = new Vector2 (Random.Range (boundary.xMin,boundary.xMax), boundary.yMax);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
