using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class TrackSelectUI : MonoBehaviour {
	public Button track1, track2, track3, back;



	
	// Update is called once per frame
	void Update () {
	
	}

	//NOTE: From the endRace scene playagain button and the pause menu quit button
	//be sure to use MusicManager.canPlay = true;

	public void Track1(){
		//Pauses the menu music while in level
		MusicManager.canPlay = false;


		//Load track one with the racer choice
		SceneManager.LoadScene("RushmoreTrack");
		//print ("Track 1");
		Racer ();

	}

	public void Track2(){
		//Pauses the menu music while in level
		MusicManager.canPlay = false;


		//Load track two with the racer choice
		SceneManager.LoadScene("OvalOfficeTrack");

		//print ("Track 2");
		Racer ();
	}

	public void Track3(){
		//Pauses the menu music while in level
		MusicManager.canPlay = false;


		//Load track three with the racer choice
		//SceneManager.LoadScene("ThirdTrackNameHere");
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
	public void Racer(){
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
