//Source File: ScoreCalculator
//Author: Franco Chong
//Date Modified: October 2, 2015
//Program Description: Set the lives that the player have.



using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour {

	//public instance variables
	public Text scoreLabel;
	public int scoreCount =0;

	// Use this for initialization
	void Start () {
		this.setScore ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//sets the score the player achieved.
	private void setScore(){
		this.scoreLabel.text = "Score: " + this.scoreCount;
	}

	//adds the score when an enemy object is destroyed or an item is picked up.
	void OnTriggerEnter2D(Collider2D otherObjects){
		if (otherObjects.tag == "Enemy") {
			this.scoreCount -= 50;
			Destroy(otherObjects.gameObject);
		}
		if (otherObjects.tag == "MedPack") {
			this.scoreCount +=100;
			Destroy (otherObjects.gameObject);
		}
		this.setScore ();		
	}

}
