//Source File: DestroyingBullet
//Author: Franco Chong
//Date Modified: September 25, 2015
//Program Description: Destroys the bullet object if it colliders with it.


using UnityEngine;
using System.Collections;

public class DestoryingBullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	//Destroys the object called bullet when it collides with it.
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Bullet") {
			Destroy (other.gameObject);
		}
		
	}
}
