using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationDrawer : MonoBehaviour {
	public Animation animation;
	// Use this for initialization
	void OnMouseDown(){

		animation["OtvaranjeLatice"].wrapMode = WrapMode.Once;
		animation.Play("OtvaranjeLatice");
		//	Debug.Log ("KLIK");
		/*if (!open) {
			opening.Play();
			transform.Translate (0, 1, 0); 

			//	x.GetComponent<Transform>().transform.Translate (0, 1, 0);  
			open = true;
		} else {
			closing.Play();
			transform.Translate (0, -1, 0); 
			//	x.GetComponent<Transform>().transform.Translate (0, -1, 0); 
			open = false;
		}*/

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
