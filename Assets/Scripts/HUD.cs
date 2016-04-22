using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour {
	public Text timeLabel;
	//public Text lapLabel;

	private float time;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;

		var minutes = time / 60; 	//Divide the guiTime by sixty to get the minutes.

		var seconds = time % 60;	//Use the euclidean division for the seconds.

		var fraction = (time * 100) % 100; //Can add fraction if we want

		//updates the HUD time text
		timeLabel.text = string.Format ("{0:00}:{1:00}:{2:00}", minutes, seconds, fraction);

		//Add lap counter code here... still deciding how to implement this
	}
}
