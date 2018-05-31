using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 1f;

	public GameObject completeUI;

	public void EndGame(){
		if (gameHasEnded == false) {
			gameHasEnded = true;
			Debug.Log ("OVER");
			Invoke ("Restart", restartDelay);
		}
	}

	void Restart (){
		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void CompleteLevel (){
		completeUI.SetActive (true);
		Debug.Log ("WON");
	}
}
