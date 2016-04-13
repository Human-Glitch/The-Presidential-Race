﻿using UnityEngine;
using System.Collections;

public class KartMovement : MonoBehaviour {


	[SerializeField] private float accRate = 1f;
	[SerializeField] private float maxSpeed = 15f;
	[SerializeField] private float turnRate = 3f;

	public float inputMask = 1f; // Turns movement on or off
	//[SerializeField] private UIScript userInterf;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}

	// Accelerates the kart based on accInput (which should be between -1 and 1). 
	// Should be called from a FixedUpdate, bc it uses the rigidbody
	public void Accelerate(float accInput) {
		accInput *= inputMask;

		// Because we only care about velocity in the xz plane, I'm removing the y component of velocity and adding it back in later.
		Vector3 velocity = rb.velocity;
		float y = velocity.y;
		velocity.y = 0;


		// Linear acceleration
		//velocity += (transform.forward * accInput * accRate);

		// Acceleration based on formula for population growth
		// dNum/dt = rate of growth * Num * (maxPop - N)/maxPop

		// When velocity = 0, dV/dt = 0, so we need to add a catch.
		// Linear acceleration when velocity = 0?
		float mag = velocity.magnitude;
		/*if (mag == 0f)
			mag = accRate;
		*/
		//No, I'm just going to add accRate to mag at that particular point.
		velocity += transform.forward * accInput * (accRate * (mag+accRate) * (maxSpeed - mag)/maxSpeed);

		// Adding y back in.
		velocity.y = y;

		// If our acceleration has us moving faster than our maxSpeed, slow down to the maxSpeed. 
		if (velocity.magnitude < maxSpeed)
			rb.velocity = velocity;
		else
			rb.velocity = velocity.normalized * maxSpeed;
		//else if (rb.velocity.magnitude >= 0f)
		//	rb.velocity = rb.velocity.normalized * maxSpeed;
		//else
		//	rb.velocity = Vector3.zero;

		// Make sure we're moving forward. 
		// I'm sure that there's a better way to integrate this with the earlier stuff, but rule 1 of optimizing. 
		y = rb.velocity.y;
		velocity = rb.velocity;
		velocity.y = 0f;
		velocity = transform.forward * velocity.magnitude;
		velocity.y = y;
		rb.velocity = velocity;

		// How fast are we going?
		print (velocity);
		//this.velocity = velocity * inputMask;
	}

	// Turns the kart based on xInput (between -1 and 1)
	// Probably call from FixedUpdate to keep it consistant with Accelerate, but this uses transform instead of RigidBody, so I don't have a clue.
	public void Turn(float xInput) {
		xInput *= inputMask;
		// We never rotate around x or z. At least on purpose.
		// Use (velocity.magnitude + turnRate) so we can still turn a little when we're stopped.
		// Not realistic, but also not supper annoying.
		// Also scale velocity.magnitude so that it's between 0 and 1. Hopefully.
		transform.Rotate (0, xInput * turnRate * ((rb.velocity.magnitude/maxSpeed) + 10*turnRate), 0);
		/*Vector3 rotation = transform.rotation.eulerAngles;
		rotation.y += xInput * turnRate * rb.velocity.magnitude;
		transform.rotation.eulerAngles = rotation;*/
		//transform.rotation.eulerAngles.y += xInput * turnRate * rb.velocity.magnitude;
	}

	/*public void Rotate(Vector3 rotation)
	{
		this.rotation = rotation * inputMask;
	}*/

	void FixedUpdate() {
		//rb.MovePosition (rb.position + velocity * Time.fixedDeltaTime);
		//Vector3 localRotation = new Vector3 (rotation.x, 0, 0);
		//Vector3 globalRotation = new Vector3 (0, rotation.y, 0);
		/*rb.MoveRotation (rb.rotation * Quaternion.Euler (rotation));

		if (inputMask > 0 && rb.position.y < 0) {
			inputMask = 0f;
			userInterf.Win ();
		}*/
	}
}
