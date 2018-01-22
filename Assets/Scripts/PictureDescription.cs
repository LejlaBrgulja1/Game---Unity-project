using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PictureDescription : MonoBehaviour {
	public Text name;
	// Use this for initialization
	void OnTriggerEnter(Collider other){

		if (other.CompareTag ("Player")) {
			name.enabled = true;
		}

	}
	void OnTriggerExit(Collider other){
		if (other.CompareTag ("Player")) {

			name.enabled = false;
		}
	}
}
