using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionController : MonoBehaviour {

	public float thrust;
	public float maxDistance;
	private Rigidbody2D rb;
	private float initialY;
	private bool up;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		initialY = rb.position.y;
		up = true;
	}		
	
	// Update is called once per frame
	void FixedUpdate () {
		if (up) {
			rb.velocity = new Vector2(0, thrust * Time.deltaTime);
		}
		if (rb.position.y >= initialY + maxDistance) {
			up = false;
		}
		if (rb.position.y <= initialY) {
			up = true;
		}
	}
}
