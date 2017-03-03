using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MapNextLevel : MonoBehaviour {
	public void NextNevel(){
		LevelManager.LoadLevel (this.name);
	}
}
