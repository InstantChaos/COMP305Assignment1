//Source File: EnemyController
//Author: Franco Chong
//Date Modified: September 23, 2015
//Program Description: Controls the enemy position and speed.


using UnityEngine;
using System.Collections;

//Re-usable codes
[System.Serializable]
public class Speed{
	public float minSpeed, maxSpeed;
}

[System.Serializable]
public class Boundary{
	public float xMin, xMax, yMin, yMax;
}


public class EnemyController : MonoBehaviour {
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
