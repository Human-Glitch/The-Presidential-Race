using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseUI : MonoBehaviour {
	public Button cont, restart, options, exit;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ContinueRace(){
		print ("Lets Race!");
		//start clock again

	}

	public void Restart(){
		print ("Back to Start!");
		//load starting scene of specific race
	}

	public void OptionsLoad(){
		//print ("Options");
		// display options scene
		SceneManager.LoadScene("Options");
	}

	public void BackToTitle(){
		//print ("Title Page Loaded");
		// quits the current race and goes back to the title screen
		SceneManager.LoadScene("Title");
	}
}