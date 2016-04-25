using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ControlsUI : MonoBehaviour {
	public Button back;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Back(){
		//Load the options scene
		SceneManager.LoadScene("Options");
	}
}
