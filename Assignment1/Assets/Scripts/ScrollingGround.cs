using UnityEngine;
using System.Collections;

public class ScrollingGround : MonoBehaviour {
	// public instanced variables

	public float speed; //this will be used to determine the speed of the movement of the background
	
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
		
		// the game object is moved to the current position
		gameObject.GetComponent<Transform> ().position = curPosition;
		
		// checks the boundary in order for it to reset
		if (curPosition.y <= -13) {
			this.Reset();
		}
	}
	
	// Resets the background
	private void Reset() {
		Vector2 resPosition = new Vector2 (0.0f, 6f);
		gameObject.GetComponent<Transform> ().position = resPosition;
	}
}
