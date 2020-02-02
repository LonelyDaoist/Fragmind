using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Rigidbody2D WeaponPrefab;
	public float power;
	public int timer;
	private int old = -1;

	void Update () {
		int current = (int)Time.time;
		if (current != old && current%timer == 0) {
			Rigidbody2D weapon = Instantiate(WeaponPrefab, new Vector2(transform.position.x - 0.5f, transform.position.y), Quaternion.identity);
			weapon.AddForce(new Vector2(-power, 0));
			old = current;
		}
	}
}
