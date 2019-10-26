using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character1 : MonoBehaviour {

	public Transform Character2;
	
	void Start () {
		
	}
	
	void Update () 
	{
		/*
			Quaternion rotation = Quaternion.LookRotation
				(Character2.transform.position - transform.position, Character2.TransformDirection(Vector3.down));
				transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w); 
		*/
	}

	void OnCollisionEnter2D (Collision2D myCol){
		if(myCol.gameObject.tag == "Obstacles1"){
			SceneManager.LoadScene("Main");
		}
	}
}
