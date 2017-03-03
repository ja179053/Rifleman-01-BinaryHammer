using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowCommands : SingletonPattern<MonoBehaviour> {
	static Text commandText;

	public static void UpdateText(string s, Transform t){
		if (commandText == null) {
			commandText = GameObject.Find ("Command Text").GetComponent<Text>();
		}
		commandText.text = s;
		if (s != "") {
			commandText.transform.parent.position = t.position + new Vector3 (0, 0, 2);
			Vector3 v = Camera.main.transform.forward * 40;
			v.x = 25;
			v.y = -5;
			commandText.transform.localPosition = v;
			//	t.LookAt (Camera.main.transform);
			commandText.transform.rotation = Camera.main.transform.rotation;
		}
	}
}
