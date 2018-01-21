﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		Movement();
	}

	void Movement(){
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0,(speed)*Time.deltaTime,0); anim.SetInteger ("dir", 0); anim.speed = 1;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate ((-speed)*Time.deltaTime,0,0); anim.SetInteger ("dir", 2); anim.speed = 1;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0,(-speed)*Time.deltaTime,0); anim.SetInteger ("dir", 1); anim.speed = 1;
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate ((speed) * Time.deltaTime, 0, 0); anim.SetInteger ("dir", 3); anim.speed = 1;
		} else
			anim.speed = 0;
	}
}
