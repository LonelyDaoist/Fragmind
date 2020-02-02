using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGame : MonoBehaviour {

	public string lvl;
	private GameObject Fragmind;
	void Start() {
		Fragmind = GameObject.FindWithTag("Fragmind");
	}

	void LateUpdate() {
		if (!Fragmind.activeSelf) {
			StartCoroutine(DelayLoadLevel());
			
		}
	}
	IEnumerator DelayLoadLevel() {
		yield return new WaitForSeconds(5);
		Application.LoadLevel(lvl);
	}
}
