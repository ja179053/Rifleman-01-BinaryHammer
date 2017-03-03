using UnityEngine;
using System.Collections;

public class GameManager : LevelManager {
	public static bool paused = false;
	static bool Paused{
		get {
			return paused;
		} set {
			paused = value;
			Time.timeScale = (paused) ? 0 : 1;
		}
	}
	// Use this for initialization
	void Start () {
		Cursor.lockState = (cursorLock) ? CursorLockMode.Locked : CursorLockMode.None;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Paused = !Paused;
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			Application.Quit ();
			Debug.Break ();
		}
	}
	public static void GameOver(){
		Debug.Break();
		//LoadLevel (0);
	}
}
