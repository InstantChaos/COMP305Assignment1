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
