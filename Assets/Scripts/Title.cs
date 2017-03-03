using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Title : LevelManager {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void MouseLock(bool mouseLock){		
		cursorLock = mouseLock;
	}
	public void SetHead(bool headLook){
		PlayerMove.head = headLook;
		LoadLevel ();
	}
}
