using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TrackSelectUI : MonoBehaviour {
	public Button track1, track2, track3, back;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//possibly call the music manager to check the racer choice
	//make method for racer choices
	public void Track1(){
		//Load track one with the racer choice
		//print ("Track 1");
		Racer ();

	}

	public void Track2(){
		//Load track two with the racer choice
		//print ("Track 2");
		Racer ();
	}

	public void Track3(){
		//Load track three with the racer choice
		//print ("Track 3");
		Racer ();
	}

	public void Back(){
		//Go back to character select screen
		SceneManager.LoadScene("CharSelect");
		//Resets the cahracter choice
		MusicManager.racerReset = true;
	}


	//Test method to print the player's racer choice
	public static void Racer(){
		if (MusicManager.washington == true) {
			print ("Washington");
		}

		if (MusicManager.lincoln == true) {
			print ("Lincoln");
		}

		if (MusicManager.taft == true) {
			print ("Taft");
		}
	
	}
}
