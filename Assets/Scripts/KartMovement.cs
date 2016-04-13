using UnityEngine;
using System.Collections;

public class KartMovement : MonoBehaviour {


	[SerializeField] private float accRate = 1f;
	[SerializeField] private float maxSpeed = 15f;
	[SerializeField] private float turnRate = 3f;

	public float inputMask = 1f;
	//[SerializeField] private UIScript userInterf;

	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void Accelerate(float accInput) {
		accInput *= inputMask;
		Vector3 velocity = rb.velocity;
		velocity += (transform.forward * accInput * accRate);
		if (velocity.magnitude < maxSpeed)
			rb.velocity = velocity;
		else if (rb.velocity.magnitude >= 0f)
			rb.velocity = rb.velocity.normalized * maxSpeed;
		else
			rb.velocity = Vector3.zero;

		float y = rb.velocity.y;
		velocity = rb.velocity;
		velocity.y = 0f;
		velocity = transform.forward * velocity.magnitude;
		velocity.y = y;
		rb.velocity = velocity;
		print (velocity);
		//this.velocity = velocity * inputMask;
	}

	public void Turn(float xInput) {
		xInput *= inputMask;
		print (xInput);
		transform.Rotate (0, xInput * turnRate * rb.velocity.magnitude, 0);
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
