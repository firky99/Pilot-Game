﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D myCol){
		if(myCol.gameObject.tag == "destroyCollider"){
			Destroy (gameObject);
		}
	}
}