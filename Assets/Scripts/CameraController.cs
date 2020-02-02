using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform playerTransform;
	private float distance;
	void Start () {
		distance = transform.position.x - playerTransform.position.x;
		transform.position = new Vector2(playerTransform.position.x + distance, transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2(playerTransform.position.x + distance, transform.position.y);
	}
}
