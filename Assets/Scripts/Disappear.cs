using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour {
	bool hidden=false;
	public int position = 0;
	public GameObject x;
	public string[] parent = new []{"Drawer1.1","Drawer1.2"};
	public Vector3[] positions = new []{new Vector3(2.65f,2.04f,-5.22f),new Vector3(-0.776f,1.645f,-1.813f), new Vector3(-0.776f,1.064f,-1.813f)};

	void Awake(){
		if (PlayerPrefs.GetString ("GameMode") == "newGame") {
			position = ((int)(Random.value*10f))%9;
			PlayerPrefs.SetInt ("pozicijaUSB", position);
		}else{
			position=PlayerPrefs.GetInt("pozicijaUSB");
		}

		Debug.Log (position +" hej to je to "+ PlayerPrefs.GetString ("GameMode"));
	}

	void Start(){

	//	position = ((int)(Random.value*10f))%9;


	

		switch (position) {
		case 0:
			x.transform.position=new Vector3(2.65f,2.04f,-5.2f);
			break;
		case 1:
			x.transform.parent = GameObject.Find ("Drawer1.1").transform;
			x.transform.position=new Vector3(-0.776f,1.645f,-1.813f);
			break;
		case 2:
			x.transform.parent = GameObject.Find ("Drawer1.2").transform;
			x.transform.position=new Vector3(-0.88f,0.899f,-1.856f);
			break;
		case 3:
			x.transform.parent = GameObject.Find ("Drawer1.3").transform;
			x.transform.position=new Vector3(-0.866f,0.367f,-2.10f);
			break;
		case 4:
			x.transform.parent = GameObject.Find ("Drawer2.1").transform;
			x.transform.position=new Vector3(8.068f,1.343f,-4.084f);
			break;
		case 5:
			x.transform.parent = GameObject.Find ("Drawer2.2").transform;
			x.transform.position=new Vector3(8.194f,0.907f,-3.9f);
			break;
		case 6:
			x.transform.parent = GameObject.Find ("Drawer2.3").transform;
			x.transform.position=new Vector3(8.53f,0.367f,-3.95f);
			break;
		case 7:
			x.transform.position=new Vector3(3.197f,0.415f,-5.208f);
			break;
		case 8:
			x.transform.position=new Vector3(1.825f,2.02f,-5.493f);
			break;

		default:
			break;
		
		}
	//	x.transform.position=positions[0];
	//	x.transform.position=new Vector3(2.65f,2.04f,-5.2f);
		//x.transform.parent = GameObject.Find(parent[0]).transform;
	}

	void OnMouseDown(){

		//	Debug.Log ("KLIK");
		if (!hidden) {
			x.SetActive(false);
			hidden = true;
			PlayerPrefs.SetInt ("USBvisibility", 0);//USBpokupljen
		}

	}
}
