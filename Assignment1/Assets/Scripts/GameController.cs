using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	//public instance variables
	public int TankCount;
	public GameObject enemytank;
	public float startWait;
	public float spawnWait;
	public Vector2 spawnValues;
	
	
	// Use this for initialization
	void Start () {
		//this._GenerateTank ();
		StartCoroutine (SpawnWaves ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnWaves() {
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i=0; i<TankCount; i++) {
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);
				Quaternion spawnRotation = Quaternion.Euler(0,0,270);
				
				Instantiate (enemytank, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
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
