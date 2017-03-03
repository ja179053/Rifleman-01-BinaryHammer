using UnityEngine;
using System.Collections;

public abstract class Player : Character {
//	protected static GameObject enemyManager;
	protected void PlayerSettings(){
	//	enemyManager = GameObject.Find ("Enemies");
		Setup ();
	}
	protected override void Die(){
		GameManager.GameOver ();
	}
}
