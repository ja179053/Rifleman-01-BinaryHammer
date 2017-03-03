using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowNextText : MonoBehaviour {
	public bool anyKey;
	public Text other;
	public int order;
	bool started;
	// Use this for initialization
	void Started () {
		started = true;
		other.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (order == 0) {
			if (!started) {
				Started ();
			}
		} else {
			order--;
			return;
		}
		if (Input.anyKeyDown && anyKey) {
			Advance ();
		}
	}
	public void Advance(){
		other.gameObject.SetActive (true);
		this.gameObject.SetActive (false);
	}
}
