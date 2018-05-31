using UnityEngine;

public class PlayerCollusion : MonoBehaviour {

	public PlayerMovement movement;
	public GameManager gameManager;

	void OnCollisionEnter(Collision collisionInfo){
		if (collisionInfo.collider.tag == "obstacle") {
			
			movement.enabled = false;
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}

}
