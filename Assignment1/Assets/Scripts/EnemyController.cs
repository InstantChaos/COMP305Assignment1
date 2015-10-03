using UnityEngine;
using System.Collections;

[System.Serializable]
public class Speed{
	public float minSpeed, maxSpeed;
}

[System.Serializable]
public class Boundary{
	public float xMin, xMax, yMin, yMax;
}


public class EnemyController : MonoBehaviour {
	// PUBLIC INSTANCE VARIABLES
	public Speed speed;
	public Boundary boundary;
	
	//private instance variables
	private float _CurrentSpeed;
	
	// Use this for initialization
	void Start () {
		this._Reset ();
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 currentPosition = gameObject.GetComponent<Transform> ().position;		 
		currentPosition.y -= this._CurrentSpeed;
		
		// move the gameObject to the currentPosition
		gameObject.GetComponent<Transform> ().position = currentPosition;
		
		// top boundary check - gameObject meets top of camera viewport
		if (currentPosition.y <= boundary.yMin) {
			this._Reset();
		}
	}
	
	// Resets the gameObject
	private void _Reset() {
		this._CurrentSpeed = Random.Range (speed.minSpeed, speed.maxSpeed);
		Vector2 resetPosition = new Vector2 (Random.Range (boundary.xMin,boundary.xMax), boundary.yMax);
		gameObject.GetComponent<Transform> ().position = resetPosition;
	}
}
