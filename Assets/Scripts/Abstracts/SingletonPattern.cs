using UnityEngine;
using System.Collections;

public abstract class SingletonPattern<T> : MonoBehaviour where T: MonoBehaviour {
	static T instance;
	static object _lock = new object();
	public static T Instance{
		get {
			if (instance != null) {
				lock (_lock) {
					T[] instances = FindObjectsOfType<T> ();
					for (int i = 1; i < instances.Length - 1; i++) {
						Destroy (instances [i]);
					}
				}
			}
			return instance;
		} 
	}
}
