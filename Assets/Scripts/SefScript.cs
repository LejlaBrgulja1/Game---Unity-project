using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SefScript : MonoBehaviour {
	public int Sefposition = -1;
	public GameObject x;
	void Start(){
		if (PlayerPrefs.GetString ("GameMode") == "newGame") {
			Sefposition = ((int)(Random.value * 10f)) % 5;
			PlayerPrefs.SetInt ("pozicijaSefa", Sefposition);
		}else{
			Sefposition=PlayerPrefs.GetInt("pozicijaSefa");
		}

		Debug.Log (Sefposition +"  "+ PlayerPrefs.GetString ("GameMode"));

		switch (Sefposition) {
		case 4://Scream
			x.transform.position=new Vector3(-0.983f,2.097f,-19.071f);
			break;
		case 0://monalisa
			x.transform.position=new Vector3(5.47f,2.097f,-19.09f);
			break;
		case 1://vangogh
			x.transform.position=new Vector3(23.77f,2.097f,-2.51f);
			x.transform.RotateAround(new Vector3(23.77f,2.097f,-2.51f),new Vector3(0,1,0),270);
			break;
		case 3://dali
			x.transform.position=new Vector3(-15.53f,2.097f,0.38f);
			x.transform.RotateAround(new Vector3(-15.53f,2.097f,0.38f),new Vector3(0,1,0),90);
			break;
		case 2://biserna nausnica
			x.transform.position=new Vector3(1.46f,2.097f,13.63f);
			x.transform.RotateAround(new Vector3(1.46f,2.097f,13.63f),new Vector3(0,1,0),180);
			break;

		default:
			break;

		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
