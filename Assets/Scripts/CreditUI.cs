using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class CreditUI : MonoBehaviour {
	public Button back;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Back(){
		//Load Title Screen
		SceneManager.LoadScene("Title");
		print ("Back");
	
	}
}
