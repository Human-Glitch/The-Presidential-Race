using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class OptionsUI : MonoBehaviour {
	public Button back;
	public Toggle mute;

	// Use this for initialization
	void Start () {
		mute.isOn = MusicManager.toggleState;
	}
	
	// Update is called once per frame
	void Update () {
		 
	}

	public void Controls(){
		//Load Control scene
		SceneManager.LoadScene("Controls");
	}

	public void Back(){
		//Load the title screen
		SceneManager.LoadScene("Title");
	}

	public void Mute(){
		//Mute the music

		if (mute.isOn) {
			//print ("Muted");
			MusicManager.canPlay = false;

		}

		if (!mute.isOn) {
			//print ("Playing");
			MusicManager.canPlay = true;
		}
	}
}
