using System;
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMovement : MonoBehaviour {


	[SerializeField] private float accRate = 1f;
	[SerializeField] private float maxSpeed = 15f;
	[SerializeField] private float turnRate = 3f;
	[SerializeField] private WheelCollider[] wheelColliders = new WheelCollider[4];
	[SerializeField] private GameObject[] wheelMeshes = new GameObject[4];

	public static float maxSteerAngle;

	private Quaternion[] WheelMeshLocalRotations;
	private float currentTorque;

	public float inputMask = 1f; // Turns movement on or off
	//[SerializeField] private UIScript userInterf;

	private Rigidbody rb;

	public GameObject targetWaypoint;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	
		WheelMeshLocalRotations = new Quaternion[4];
		for(int x = 0; x < 4; x++) {
			WheelMeshLocalRotations[x] = wheelMeshes[x].transform.localRotation;
		}

		wheelColliders [0].attachedRigidbody.centerOfMass = new Vector3 (0f, -1f, 0f);

		currentTorque = 2500f;
	}

	// Update is called once per frame
	void Update () {

	}
		

	public void Move(float turnInput, float accelInput) {
		for (int x = 0; x < 4; x++) {
			Quaternion quat;
			Vector3 position;
		}

		float steerAngle = turnInput * maxSteerAngle;

		}

		


}
