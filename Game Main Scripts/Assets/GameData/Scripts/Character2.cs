using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 : MonoBehaviour {

	private Vector2 mousePosition;
	public float moveSpeed = 0.1f;
	public Camera mainCamera;

	public Transform char1;

	[SerializeField]
	Animator animator;

	// Use this for initialization
	void Start () {
		Physics2D.IgnoreCollision(char1.GetComponent<Collider2D>(), GetComponent<Collider2D>());
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetMouseButton(0)){
			mousePosition = Input.mousePosition;
			mousePosition = mainCamera.ScreenToWorldPoint (mousePosition);
			transform.position = Vector2.Lerp (transform.position, 
				new Vector2(mousePosition.x, mousePosition.y + 1), moveSpeed);
			
		if(animator.GetInteger("State")!=2)
			animator.SetInteger("State",1);

			
		}else
		{
			if(animator.GetInteger("State")!=2)
			animator.SetInteger("State",0);
		}

	}

	void OnCollisionEnter2D (Collision2D myCol){
		if(myCol.gameObject.tag == "Obstacles1"){
			animator.SetInteger("State",2);
			//BackgroundEffect.instance.ShakeBackground();
		}
	}

	public void backToIdle(){
		animator.SetInteger("State",0);
	}
}