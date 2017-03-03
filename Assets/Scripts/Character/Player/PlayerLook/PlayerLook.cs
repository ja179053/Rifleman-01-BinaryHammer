using UnityEngine;
using System.Collections;

public class PlayerLook : SingletonPattern<MonoBehaviour> {
	public float sensitivity = 1, xClamp = 0, yClamp = 90;
	int inverse = 1;
	public bool useX;
	public static bool frozen = false;
	public LayerMask ui;
	// Use this for initialization
	void Start () {
	//	Cursor.lockState = CursorLockMode.Locked;
	}
	public static float x, y;
	// Update is called once per frame
	void Update () {
		if (!GameManager.paused && !frozen && (Cursor.lockState != CursorLockMode.Locked)) {
			AssignX ();
			//	x = (RaycastData.
			if (!useX) {
				SetX = 0;
			}
			if (xClamp != 0) {
				SetX = Mathf.Clamp (x, -xClamp, xClamp);
			}
			y = -(Input.mousePosition.y / Screen.height) * inverse * sensitivity;
			y = Mathf.Clamp (y, -yClamp, yClamp);
			Rotate (new Vector2 (SetX, y));
		} else {
			transform.rotation = Quaternion.Euler (Vector3.zero);
			Destroy(this.GetComponent<PlayerLook>());
		}
	}
	protected virtual void AssignX(){
		SetX = (Input.mousePosition.x / Screen.width) * sensitivity;// - Screen.width / 2;
	}
	protected  virtual void Rotate(Vector2 enter){
		transform.rotation = Quaternion.Euler (new Vector3 (enter.y, enter.x, 0));
	}
	public static float SetX{
		get {
			return x;
		} set {
			x = value;
		}
	}
}
