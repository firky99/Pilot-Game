using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 : MonoBehaviour {

	private Vector2 mousePosition;
	public float moveSpeed = 0.1f;
	public Camera mainCamera;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(1)){
			mousePosition = Input.mousePosition;
			mousePosition = mainCamera.ScreenToWorldPoint (mousePosition);
			transform.position = Vector2.Lerp (transform.position, mousePosition, moveSpeed);
		}
	}

	//void OnCollisionEnter (CircleCollider2D collision ){
		//if(collision.gameObject.tag == "Char1"){
			//Physics.IgnoreCollision(collision.collider, GetComponent<CircleCollider2D>());
		//}
	//}
}
