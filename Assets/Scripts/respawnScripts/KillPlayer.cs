using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	private LevelManager levelManager;//does not work with prefabs so keep private
	public AudioSource dyingSound;

	// Use this for initialization
	void Start () {
		//dyingSound = GetComponent<AudioSource> ();

		levelManager = FindObjectOfType<LevelManager> ();// finds an object with level manager attacthed

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {

			Debug.Log ("DEAD");
			//dyingSound.Play ();
			levelManager.RespawnPlayer ();

		}
	}
}
