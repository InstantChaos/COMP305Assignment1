//Source File: DetroyingCollider
//Author: Franco Chong
//Date Modified: September 25, 2015
//Program Description: Destroys each game object when conditions are met.


using UnityEngine;
using System.Collections;

public class DestroyingCollider : MonoBehaviour {

	private AudioSource EnemyDyingSound;
	

	// Use this for initialization
	void Start () {

		this.EnemyDyingSound = this.GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Destroys certain objects when a condition is met.
	void OnTriggerEnter2D(Collider2D otherObjects){
		if (otherObjects.tag == "Player") {
			Destroy(gameObject);
			this.EnemyDyingSound.Play ();
		}
		if (otherObjects.tag == "Bullet") {
			Destroy(otherObjects.gameObject);
			Destroy (gameObject);
			this.EnemyDyingSound.Play ();

		}
	}
}
