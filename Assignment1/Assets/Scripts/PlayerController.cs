//Source File: PlayerController
//Author: Franco Chong
//Date Modified: September 23, 2015
//Program Description: Controls the player object for it to move around and fire a bullet object.


using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	//public instance variables
	public float speed;
	public Boundary boundary;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextShot;
	
	//private instance variables
	private Vector2 newPos = new Vector2 (0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//checks the input for the player to fire a bullet object.
		this.CheckInput ();
		if (Input.GetButton ("Fire1") && Time.time > nextShot) {
			nextShot = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}




	private void CheckInput(){
		//current position of the player object
		this.newPos = gameObject.GetComponent<Transform> ().position; 

		//adds speed to the current position
		if (Input.GetAxis ("Horizontal") > 0) {
			newPos.x += this.speed;
			
		}
		//subtract speed from the current position
		if (Input.GetAxis ("Horizontal") < 0) {
			newPos.x -= this.speed;
			
		}
		
		this.BoundaryCheck ();
		
		gameObject.GetComponent<Transform>().position = this.newPos;
	}

	//checks the boundary of the position so that it does not go off the screen.
	private void BoundaryCheck(){
		if (this.newPos.x < this.boundary.xMin) {
			this.newPos.x = this.boundary.xMin;
		}
		
		if (this.newPos.x > this.boundary.xMax) {
			this.newPos.x = this.boundary.xMax;
		}
	}
	
	
}
