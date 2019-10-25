using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character1 : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D myCol){
		if(myCol.gameObject.tag == "Obstacles1"){
			SceneManager.LoadScene("Main");
		}
	}
}
