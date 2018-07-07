using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myscript : MonoBehaviour {
	float zvalue = 0f;
	float dx = 0.01f;
	float dy = -0.01f;

	void Start () {
		Debug.Log ("unnko");
        Debug.log("huwibsi");
        

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 s = transform.localScale;
		if (s.x > 3 || s.x < 1) {


			dx *= -1;


		}
		if (s.y > 3 || s.y < 0.1) {

			dy *= -1;

		}

		s.x += dx;

		s.y += dy;
		transform.localScale = s;
	

		}
}
