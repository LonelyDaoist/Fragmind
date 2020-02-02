using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectFrags : MonoBehaviour {

	public Text Vision;
	private Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Fragmind")) {
			Debug.Log("Collected");
			other.gameObject.SetActive(false);
			Vision.gameObject.SetActive(true);
			rb.constraints = RigidbodyConstraints2D.FreezePosition;
		}
	}
}

