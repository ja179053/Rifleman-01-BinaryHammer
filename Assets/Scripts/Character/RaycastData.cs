using UnityEngine;
using System.Collections;

public static class RaycastData {
	static RaycastHit rayh;
	public static bool RaycastBlocked(Vector3 start, Vector3 end){
		Ray r = new Ray (start, end);
		return Physics.Raycast (r, out rayh);
	}
	public static Vector3 RayPoint(Ray ray, LayerMask lm){
		if (Physics.Raycast (ray, out rayh, 10000, lm)) {
			return rayh.point;
		}
		return ray.origin;
	}
}
