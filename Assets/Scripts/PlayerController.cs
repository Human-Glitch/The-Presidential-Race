using UnityEngine;
using System.Collections;

[RequireComponent(typeof(KartMovement))]

public class PlayerController : MonoBehaviour {

	private KartMovement movement;


	// Use this for initialization
	void Start () {
		movement = GetComponent<KartMovement> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float acc = Input.GetAxis ("Accelerate");
		float x = Input.GetAxis ("Horizontal");
		//if (acc == 0)
		//	acc = x;
		//Vector3 acc = transform.right * z;
		//Vector3 movVert = transform.forward * z;
		//Vector3 velocity = (movHoriz + movVert).normalized;

		movement.Accelerate (acc);
		movement.Turn (x);
		/*
		float yRot = Input.GetAxis ("Mouse X");
		float xRot = 0;//-Input.GetAxis ("Mouse Y");
		Vector3 rotation = new Vector3 (xRot, yRot, 0);
		movement.Rotate (rotation);*/
	}
}
