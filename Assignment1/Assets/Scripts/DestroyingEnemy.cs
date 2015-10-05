//Source File: DestroyingEnemy
//Author: Franco Chong
//Date Modified: September 25, 2015
//Program Description: Destroys the enemy object when it collides with this object.



using UnityEngine;
using System.Collections;

public class DestroyingEnemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//Destroys the enemy object upon collision.
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
		}
		if (other.tag == "MedPack") {
			Destroy (other.gameObject);
		}
		
	}
}
