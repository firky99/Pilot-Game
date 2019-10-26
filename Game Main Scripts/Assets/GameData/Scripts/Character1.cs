using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character1 : MonoBehaviour {

	public Transform Character2;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(
			//new Vector3(Character2.position.x, 
						//	transform.position.y,
						//	transform.position.z));
		
	}

	void OnCollisionEnter2D (Collision2D myCol){
		if(myCol.gameObject.tag == "Obstacles1"){
			SceneManager.LoadScene("Main");
		}
	}
}
