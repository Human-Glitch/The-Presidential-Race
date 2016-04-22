using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CharSelectUI : MonoBehaviour {
	public Button racer1, racer2, racer3, back;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Back(){
		//Go back to title screen
		SceneManager.LoadScene("Title");
	}

	//sends the racer choice into the track selction screen
	public void Racer1(){
		print ("Racer1");
	}

	public void Racer2(){
		print ("Racer2");
	}

	public void Racer3(){
		print ("Racer3");
	}
}
