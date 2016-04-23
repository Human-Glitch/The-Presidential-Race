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

	public void Track1(){
		//Load track one with the racer choice
		print ("Track 1");

	}

	public void Track2(){
		//Load track two with the racer choice
		print ("Track 2");
	}

	public void Track3(){
		//Load track three with the racer choice
		print ("Track 3");
	}

	public void Back(){
		//Go back to character select screen
		SceneManager.LoadScene("CharSelect");
	}
}
