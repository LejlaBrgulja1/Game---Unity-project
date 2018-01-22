using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : MonoBehaviour {
	float speed=0.7f;
	bool open=false;
	//public GameObject x;
	public AudioSource opening;   // drag the sounds in the Inspector
	public AudioSource closing;

	float t;
	Vector3 startPosition;
	Vector3 target;
	float timeToReachTarget;
	void Start()
	{
		startPosition = target = transform.position;

	}
	void Update() 
	{
		t += Time.deltaTime/timeToReachTarget;
		transform.position = Vector3.Lerp(startPosition, target, t);
	}
	public void SetDestination(Vector3 destination, float time)
	{
		t = 0;
		startPosition = transform.position;
		timeToReachTarget = time;
		target = destination; 
	}

	void OnMouseDown(){

	//	Debug.Log ("KLIK");
		if (!open) {
			opening.Play();
			SetDestination (transform.position+new Vector3(0,0,-1),speed); 
			//transform.Translate (0, 1, 0); 

		//	x.GetComponent<Transform>().transform.Translate (0, 1, 0);  
			open = true;
		} else {
			closing.Play();
			//transform.Translate (0, -1, 0); 
			SetDestination (transform.position+new Vector3(0,0,1),speed); 
		//	x.GetComponent<Transform>().transform.Translate (0, -1, 0); 
			open = false;
		}
	
	}


}
