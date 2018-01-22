using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TimerScript : MonoBehaviour {
	public Text timerText;
	private bool stopped = false;
	private float startTime;
	public float old = 0;

	void Awake(){
		if (PlayerPrefs.GetString ("GameMode") == "newGame") {
			old =0;
		
		}else{
			old=PlayerPrefs.GetFloat("time");
		}
	}
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (stopped)
			return;
		float t = Time.time - startTime + old;
		PlayerPrefs.SetFloat ("time", t);
		string minutes = ((int)t / 69).ToString ();
		string seconds = (t % 60).ToString ("f2");
		timerText.text = minutes + ":" + seconds;
	}

	public void StopTimer(){
		stopped = true;
		timerText.color = Color.yellow;
	}
}
