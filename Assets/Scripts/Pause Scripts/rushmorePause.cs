using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class rushmorePause : MonoBehaviour {
	public Button cont, restart, exit;

	public Canvas pauseCanvas;


	// Use this for initialization
	void Start () {
		pauseCanvas.enabled = false;

	}

	// Update is called once per frame
	void Update () {

		//Pause menu control
		if (Input.GetKeyDown (KeyCode.Escape)) {
			print ("PAUSED!");
			Time.timeScale = 0.0f;
			pauseCanvas.enabled = true;
		}


	}
	public void ContinueRace(){
		print ("Lets Race!");
		//start clock again
		Time.timeScale = 1.0f;
		pauseCanvas.enabled = false;

	}

	public void Restart(){
		print ("Back to Start!");
		pauseCanvas.enabled = false;
		Time.timeScale = 1.0f;
		SceneManager.LoadScene ("RushmoreTrack");

	}


	public void BackToTitle(){
		//print ("Title Page Loaded");
		// quits the current race and goes back to the title screen
		SceneManager.LoadScene("Title");
	}
}