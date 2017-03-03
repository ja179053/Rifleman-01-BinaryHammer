using UnityEngine;
using System.Collections;

public class CameraZoom : Mechanic {
	public float normView, zoomView, zoomSpeed = 1;
	// Update is called once per frame
	void Update () {
		float f = (Input.GetKey (triggerKey)) ? zoomView : normView;
		Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, f, Time.deltaTime * zoomSpeed);
	}
}
