using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class OptionsUI : MonoBehaviour {
	public Button back;
	public Toggle mute;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Back(){
		//Load the title screen
		SceneManager.LoadScene("Title");
	}

	public void Mute(){
		//Mute the music

		if (mute.isOn) {
			print ("Muted");
		}

		if (!mute.isOn) {
			print ("Playing");
		}
	}
}
