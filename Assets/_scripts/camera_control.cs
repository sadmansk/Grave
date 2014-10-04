using UnityEngine;
using System.Collections;

public class camera_control : MonoBehaviour {
	public Transform player;
	private Vector3 offset;

	void Start() {
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.position + offset;
	}
}
