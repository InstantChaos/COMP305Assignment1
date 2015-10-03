//Source File: BulletMover
//Author: Franco Chong
//Date Modified: September 23, 2015
//Program Description: Moves the bullet object in a certain direction.



using UnityEngine;
using System.Collections;

public class BulletMover : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//Moves the bullet object in a certain direction and speed.
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x , speed );
	}
}
