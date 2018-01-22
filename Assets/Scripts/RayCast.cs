using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class Highscore{
	public string player;
	public float score;
}

public class RayCast : MonoBehaviour {

	public Camera playerCamera;
	public Camera laptopCamera;
	public Camera laptop2Camera;
	public GameObject USB;
	public GameObject[] pictures;
	public Text[] names;
	public Text hint;



	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		int Sefposition = PlayerPrefs.GetInt("pozicijaSefa");
		float theDistance;
		Vector3 forward = transform.TransformDirection (Vector3.forward) * 2.5f;
		Debug.DrawRay (transform.position, forward, Color.green);
		bool finish = false;
		if (Physics.Raycast (transform.position, (forward), out hit)) {
			theDistance = hit.distance;
			if (hit.collider.gameObject.name == "Monitor" && Input.GetKey(KeyCode.LeftShift)) {
				playerCamera.enabled = false;
				laptopCamera.enabled = true;
				hint.enabled = true;
			}else if (!playerCamera.enabled && Input.GetKey(KeyCode.Space)) {
				playerCamera.enabled = true;
				laptopCamera.enabled = false;
				hint.enabled = false;
			}else if (hit.collider.gameObject.name == "Monitor2" && Input.GetKey(KeyCode.LeftShift) && !USB.active) {
				playerCamera.enabled = false;
				laptop2Camera.enabled = true;
			}else if (hit.collider.gameObject.name == "Monitor2" && Input.GetKey(KeyCode.Space) && !USB.active) {
				playerCamera.enabled = true;
				laptop2Camera.enabled = false;
				names[Sefposition].enabled = false;
			}else if(!playerCamera.enabled && Input.GetKey(KeyCode.Space)){
				playerCamera.enabled = true;
				laptop2Camera.enabled = false;
				laptopCamera.enabled = false;
				names[Sefposition].enabled = false;
			}else if(hit.collider.gameObject.name == "Pic1" && Input.GetKey(KeyCode.M) && !USB.active && Sefposition==0){
				pictures [0].transform.position += new Vector3 (-1.5f,0f,0f);
				finish = true;
			}else if(hit.collider.gameObject.name == "Pic2" && Input.GetKey(KeyCode.V) && !USB.active && Sefposition==1){
				pictures [1].transform.position += new Vector3 (0f,0f,-1.5f);
				finish = true;
			}else if(hit.collider.gameObject.name == "Pic3" && Input.GetKey(KeyCode.P) && !USB.active && Sefposition==2){
				pictures [2].transform.position += new Vector3 (-1.5f,0f,0f);
				finish = true;
			}else if(hit.collider.gameObject.name == "Pic4" && Input.GetKey(KeyCode.D) && !USB.active && Sefposition==3){
				pictures [3].transform.position += new Vector3 (0f,0f,-1.5f);
				finish = true;
			}else if(hit.collider.gameObject.name == "Pic5" && Input.GetKey(KeyCode.S) && !USB.active && Sefposition==4){
				pictures [4].transform.position += new Vector3 (-1.5f,0f,0f);
				finish = true;
			}
			if (finish) {
		/*		Highscore highscore = new Highscore ();
				highscore.player = PlayerPrefs.GetString ("player");
				highscore.score = PlayerPrefs.GetFloat ("time");

				XmlSerializer serializer = new XmlSerializer (typeof(List<Highscore>));
				List<Highscore> highscores = new List<Highscore> ();
				using (XmlTextReader reader = new XmlTextReader ("highscores.xml")) {
					highscores = (List<Highscore>)serializer.Deserialize (reader);
				}

				highscores.Add (highscore);
				using (StreamWriter open = new StreamWriter ("highscores.xml")) {
					serializer.Serialize (open, highscores);
				}

				PlayerPrefs.DeleteAll ();*/

				SceneManager.LoadScene (2);
			}
			if (laptop2Camera.enabled) {
				names[Sefposition].enabled = true;
			}


		}
	}
}
