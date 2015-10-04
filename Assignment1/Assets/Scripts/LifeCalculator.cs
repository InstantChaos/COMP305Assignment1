//Source File: LifeCalculator
//Author: Franco Chong
//Date Modified: October 2, 2015
//Program Description: Set the lives that the player have.


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeCalculator : MonoBehaviour {
	
	public Text livesLabel;
	public int livescount = 5;


	// Use this for initialization
	void Start () {

		//calls the setLives method to set the total number of lives
		this.setLives ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//set the number of lives available for the player.
	private void setLives(){
		this.livesLabel.text = "Lives: " + this.livescount;
	}

	//Lives will be deducted upon sensing a collision.
	void OnTriggerEnter2D(Collider2D otherObjects){
		if (otherObjects.tag == "Enemy") {
			this.livescount -= 1;
			Destroy(otherObjects.gameObject);
		}
		this.setLives ();		
	}
}
