using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Messenger : MonoBehaviour {
	static Text messageText;
	static List<Message> messages;
	// Use this for initialization
	void Start () {
		if (messageText == null) {
			messageText = GetComponent<Text> ();
		}
		messages = new List<Message>();
		StartCoroutine (PlayMessage ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void NewMessage(string message, float readTime = 10){
		if (messages.Count == 0 || message != messages [messages.Count - 1].message) {
			Message m = new Message (message, readTime);
			messages.Add (m);
		}
	}
	IEnumerator PlayMessage(){
		messageText.text = "";
		yield return new WaitUntil (() => (messages.Count != 0));
		messageText.text = messages [0].message;
		yield return new WaitForSeconds(messages[0].time);
		messages.RemoveAt (0);
		StartCoroutine (PlayMessage ());
	}
	bool LongMessage(){
		if (messages [0].message.Length > 1) {
			return true;
		}
		return false;
	}
}
class Message{
	public string message;
	public float time;
	public Message(string s, float t){
		message = s;
		time = t;
	}
}
