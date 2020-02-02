using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	public float thrust;
	public float torque;
	public string lvl;
	private Rigidbody2D rb;
	private bool onGround;
	void Start () {
		onGround = true;
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2(speed, rb.velocity.y);
		if (Input.GetKeyDown(KeyCode.Space) && onGround) {
			rb.velocity = new Vector2(rb.velocity.x, thrust);
			rb.MoveRotation(rb.rotation + torque);
			onGround = false;
		}
		if (rb.position.y <= -10) {
			Application.LoadLevel(lvl);
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Enemy")) {
			Application.LoadLevel(lvl);
		}
		if (other.gameObject.CompareTag("Speeder")) {
			speed *=2;
		}
	}
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.CompareTag("Enemy")) {
			Application.LoadLevel(lvl);
		}
		if (other.gameObject.CompareTag("Platform")) {
			onGround = true;
		}
	}
}
