using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	//public instance variables
	public float speed;
	public Boundary boundary;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	private float nextFire;
	
	//private instance variables
	private Vector2 _newPosition = new Vector2 (0.0f, 0.0f);
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this._CheckInput ();
		if (Input.GetButton ("Fire1") && Time.time > nextFire) {
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}




	private void _CheckInput(){
		this._newPosition = gameObject.GetComponent<Transform> ().position; //current position
		
		if (Input.GetAxis ("Horizontal") > 0) {
			_newPosition.x += this.speed;//add movee value to current position
			
		}
		if (Input.GetAxis ("Horizontal") < 0) {
			_newPosition.x -= this.speed;//subtract movee value to current position
			
		}
		
		this._BoundaryCheck ();
		
		gameObject.GetComponent<Transform>().position = this._newPosition;
	}
	
	private void _BoundaryCheck(){
		if (this._newPosition.x < this.boundary.xMin) {
			this._newPosition.x = this.boundary.xMin;
		}
		
		if (this._newPosition.x > this.boundary.xMax) {
			this._newPosition.x = this.boundary.xMax;
		}
	}
	
	
}
