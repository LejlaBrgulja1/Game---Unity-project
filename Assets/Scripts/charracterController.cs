using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charracterController : MonoBehaviour {
	public float speed = 10.0F;

	void Start () {
	}

	void Update () {
		float translation = Input.GetAxis ("Vertical") * speed;
		float straffe = Input.GetAxis ("Horizontal") * speed;
		translation *= Time.deltaTime;
		straffe *= Time.deltaTime;
		transform.Translate (straffe, 0, translation);

		PlayerPrefs.SetFloat ("Xposition", transform.position.x);//X koordinata igraca
		PlayerPrefs.SetFloat ("Yposition", transform.position.y);//Y koordinata igraca
		PlayerPrefs.SetFloat ("Zposition", transform.position.z);//Z koordinata igraca

	}
}
