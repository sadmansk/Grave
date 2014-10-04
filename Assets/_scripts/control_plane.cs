using UnityEngine;
using System.Collections;

public class control_plane : MonoBehaviour {
	//declares the speed variables
	float speed = 1.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float xRotate = Input.GetAxis ("Vertical") * speed;
		float zRotate = Input.GetAxis ("Horizontal") * speed;

		transform.Rotate(xRotate, 0, zRotate);
	}
}
