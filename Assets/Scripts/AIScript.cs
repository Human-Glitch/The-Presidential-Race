using UnityEngine;
using System.Collections;

[RequireComponent(typeof(KartMovement))]

public class AIScript : MonoBehaviour {

	private Vector3 targetPoint;
	private KartMovement movement;

	// Use this for initialization
	void Start () {
		movement = GetComponent<KartMovement> ();
	}

	void FixedUpdate() {
		Vector3 bearing = targetPoint - transform.position;
		bearing.y = 0;
		bearing.Normalize ();

		Vector3 current = transform.forward;
		current.y = 0;
		current.Normalize ();

		float theta = Mathf.Atan (current.z / current.x);
		if (current.x < 0) {
			if (theta < 0)
				theta += Mathf.PI;
			else
				theta -= Mathf.PI;
		}

		float targetTheta = Mathf.Atan (bearing.z / bearing.x);
		if (bearing.x < 0) {
			if (targetTheta < 0)
				targetTheta += Mathf.PI;
			else
				targetTheta -= Mathf.PI;
		}

		float deltaTheta = targetTheta - theta;

		if(deltaTheta < -Mathf.PI) 
			deltaTheta += 2*Mathf.PI;
		if(deltaTheta >= Mathf.PI)
			deltaTheta -= 2*Mathf.PI;

		float input = 0f;
		if (Mathf.Abs (deltaTheta) < 0.1f)
			deltaTheta = 0f;
		
		if (deltaTheta < 0)
			input = 1f;
		else if (deltaTheta > 0)
			input = -1f;

		movement.Accelerate (1);
		movement.Turn (input);
	}

	public void SetTarget(Vector3 nextTarget) {
		targetPoint = nextTarget;
	}
}
