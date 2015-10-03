using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour {

	public Text scoreLabel;
	public int scoreCount =0;

	// Use this for initialization
	void Start () {
		this.setScore ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void setScore(){
		this.scoreLabel.text = "Score: " + this.scoreCount;
	}

	void OnTriggerEnter2D(Collider2D otherObjects){
		if (otherObjects.tag == "Enemy") {
			this.scoreCount += 10;
			Destroy(otherObjects.gameObject);
		}
		this.setScore ();		
	}

}
