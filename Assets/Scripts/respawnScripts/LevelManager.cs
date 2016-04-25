using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public GameObject currentCheckpoint;
	public GameObject deathParticle;
	public GameObject respawnParticle;
	public GameObject player;

	public float respawnDelay;


	private bool notDead = true;



	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer (){
		StartCoroutine ("RespawnPlayerCo");
		
	}

	public IEnumerator RespawnPlayerCo(){
		Debug.Log ("Player Respawn");

		if (notDead) {

			Instantiate (deathParticle, player.transform.position, player.transform.rotation);
			notDead = false;

			player.active = false;

			yield return new WaitForSeconds (respawnDelay);

			player.transform.position = currentCheckpoint.transform.position;
			player.active = true;

			Instantiate (respawnParticle, currentCheckpoint.transform.position, currentCheckpoint.transform.rotation);
			notDead = true;
		}
	}
}
