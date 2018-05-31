using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is the reffrence for Rigidbody
	public Rigidbody rb;
	public float forwardForce = 2000f ;
	public float sideForce = 500f ;

	
	// Corrected the physics
	void Update () {
		// Here we corrected the defferenece of frame rate
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey ("d")) {
			rb.AddForce (sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey ("a")) {
			rb.AddForce (-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager>().EndGame ();
		}

		//if (Input.GetKey ("w")) {
		//	rb.AddForce (0, sideForce * Time.deltaTime, 0);
		//}
	}
}
