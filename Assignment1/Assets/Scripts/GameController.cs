//Source File: GameController
//Author: Franco Chong
//Date Modified: September 23, 2015
//Program Description: Controls the game that will spawn the enemy tanks for the player to shoot.


using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//public instance variables
	public int TankCount;
	public GameObject enemytank;
	public float start;
	public float spawn;
	public Vector2 spawnrate;
	
	
	// Use this for initialization
	void Start () {
		//this._GenerateTank ();

		//this will call the spawnwaves method for the program to spawn the enemy tanks object.
		StartCoroutine (SpawnWaves ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//sets the position of the enemy tank objects for the game to use.
	IEnumerator SpawnWaves() {
		yield return new WaitForSeconds (start);
		while (true) {
			for (int i=0; i<TankCount; i++) {
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnrate.x, spawnrate.x), spawnrate.y);
				Quaternion spawnRotation = Quaternion.Euler(0,0,270);
				
				Instantiate (enemytank, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawn);
				                     
			}
		}
	}

		//generate enemy tanks
//	private void _GenerateTank(){
//		for (int count =0; count < this.TankCount; count++) {
//			Instantiate(enemytank);
//		}
//	}
}
