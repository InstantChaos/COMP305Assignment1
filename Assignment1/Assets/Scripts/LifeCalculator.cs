using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LifeCalculator : MonoBehaviour {
	
	public Text livesLabel;
	public int livescount = 5;


	// Use this for initialization
	void Start () {

		this.setLives ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void setLives(){
		this.livesLabel.text = "Lives: " + this.livescount;
	}

	void OnTriggerEnter2D(Collider2D otherObjects){
		if (otherObjects.tag == "Enemy") {
			this.livescount -= 1;
			Destroy(otherObjects.gameObject);
		}
		this.setLives ();		
	}
}
