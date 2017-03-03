using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {
	[SerializeField]
	protected static bool cursorLock;
	protected void LoadLevel(int i = -1){
		if (i < 0) {
			i = SceneManager.GetActiveScene ().buildIndex + 1;
		}
		SceneManager.LoadScene (i);
	}
	public static void LoadLevel(string s){
		SceneManager.LoadScene (s);
	}
}
