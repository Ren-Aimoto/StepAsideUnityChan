using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour {
	GameObject CameraPos;
	// Use this for initialization
	void Start () {
		this.CameraPos = GameObject.Find ("Main Camera");

	}
	
	// Update is called once per frame
	void Update () {
		if (this.CameraPos.transform.position.z > gameObject.transform.position.z) {
			Destroy (gameObject);
		}
	}
}
