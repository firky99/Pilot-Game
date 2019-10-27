using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Character1 : MonoBehaviour {
	
	public GameObject gameOver;
	public GameObject playGameUI;
	public GameObject playGameMain;

	public Transform Character2;
	public Transform[] moveTarget;


	[SerializeField]
	Animator animator;

	bool lastMoveState;

	void Start () {
		lastMoveState = false;
	}
	
	void Update () 
	{
		/*
			Quaternion rotation = Quaternion.LookRotation
				(Character2.transform.position - transform.position, Character2.TransformDirection(Vector3.down));
				transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w); 
		*/
		character1Behaviour();
	}

	void character1Behaviour() 
	{
		if(ScoreManager.instance.scoreCount >= 10 && ScoreManager.instance.scoreCount < 20)
		{
			if(transform.position.x > moveTarget[0].position.x + 0.1f)
			{
				transform.DOMove(moveTarget[0].position, 4f);	
				transform.eulerAngles = new Vector3(0, 0, 90);
				animator.SetInteger("State",1);
			}
			else
			{
				transform.eulerAngles = new Vector3(0, 0, 0);
				animator.SetInteger("State",0);
			}
		}
		else if(ScoreManager.instance.scoreCount >= 20 && ScoreManager.instance.scoreCount < 30)
		{
			if(transform.position.x < moveTarget[1].position.x - 0.1f)
			{
				transform.DOMove(moveTarget[1].position, 8f);	
				transform.eulerAngles = new Vector3(0, 0, 270);
				animator.SetInteger("State",1);
			}
			else
			{
				transform.eulerAngles = new Vector3(0, 0, 0);
				animator.SetInteger("State",0);
			}
		}
		else if(ScoreManager.instance.scoreCount >= 30)
		{
			if(!lastMoveState)
			{
				if(transform.position.x > moveTarget[0].position.x + 0.1f)
				{
					transform.DOMove(moveTarget[0].position, 6f);	
					transform.eulerAngles = new Vector3(0, 0, 90);
					animator.SetInteger("State",1);
				}
				else
				{
					transform.eulerAngles = new Vector3(0, 0, 0);
					animator.SetInteger("State",0);
					lastMoveState = true;
				}
			}
			else
			{
				if(transform.position.x < moveTarget[1].position.x - 0.1f)
				{
					transform.DOMove(moveTarget[1].position, 6f);	
					transform.eulerAngles = new Vector3(0, 0, 270);
					animator.SetInteger("State",1);
				}
				else
				{
					transform.eulerAngles = new Vector3(0, 0, 0);
					animator.SetInteger("State",0);
					lastMoveState = false;
				}
			}
		}
	}

	void OnCollisionEnter2D (Collision2D myCol){
		if(myCol.gameObject.tag == "Obstacles1"){
			//SceneManager.LoadScene("Main"); ambek yg ini
			gameOver.SetActive(true);
			playGameUI.SetActive(false);
			playGameMain.SetActive(false);
		}
	}
}
