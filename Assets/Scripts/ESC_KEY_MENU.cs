using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ESC_KEY_MENU : MonoBehaviour {
	public Canvas MainCanvas;

	//public Texture2D cursorTextureClicked;
	//public Texture2D cursorTextureNotClicked;
	//public CursorMode cursorMode = CursorMode.Auto;
	//public Vector2 hotSpot = Vector2.zero;
	public GameObject USB;
	public GameObject Sef;
	public GameObject Igrac;

	void Awake(){
		string gameMode=PlayerPrefs.GetString ("GameMode");
		if (gameMode == "resumeGame") {
			if (PlayerPrefs.GetInt ("USBvisibility") == 0)
				USB.active = false;
			
			Igrac.transform.position = new Vector3 (PlayerPrefs.GetFloat ("Xposition"), PlayerPrefs.GetFloat ("Yposition"), PlayerPrefs.GetFloat ("Zposition"));
		
		} else {
			Debug.Log ("nova  " + PlayerPrefs.GetString("player"));
		}
	}


	void Start(){
		
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = true;
	}

	public void Update ()
	{
		if (Input.GetKey (KeyCode.Escape)) {

			//PlayerPrefs.SetString ("currentTimer", timerText.text);
			SceneManager.LoadScene (0);


			//MainCanvas.enabled=true;
		}
	/*	if (Input.GetMouseButtonDown (0)) {
			Cursor.SetCursor (cursorTextureClicked, hotSpot, cursorMode);
		}
		if (Input.GetMouseButtonUp (0)) {
			Cursor.SetCursor (cursorTextureNotClicked, hotSpot, cursorMode);
		}
	*/}
}
