﻿using UnityEngine;
using System.Collections;

public class MovePusher : MonoBehaviour {

	// default position
	private Vector3 origin;

	// Use this for initialization
	void Start () {
		origin = GetComponent<Rigidbody> ().position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 offset = new Vector3 (0, 0, Mathf.Sin (Time.time));
		GetComponent<Rigidbody> ().MovePosition (origin + offset);
	}
}
