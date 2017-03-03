using UnityEngine;
using System.Collections;

public class ConstantRotate : PlayerLook {
	protected override void AssignX(){
		SetX = (Input.mousePosition.x / Screen.width) * sensitivity - (Screen.width / 2);
	}
	protected  override void Rotate(Vector2 enter){
	//	transform.rotation = Quaternion.Euler (new Vector3 (transform.rotation.x, enter.x, 0));
		transform.Rotate (Vector3.right * enter.x);
	}
}
