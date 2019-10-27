using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
	public GameObject[] BGSub;
	int state;

	void Start()
	{
		state=0;
	}

	void Update()
	{
		/*
		switch(state) 
		{
			case 0:
				BGSub[0].transform.DORotate(new Vector3(0,0,360), 0.5f, RotateMode.FastBeyond360);
				BGSub[0].transform.DOScale(1f, 0.5f);

				if(BGSub[0].transform.localScale.x >= 0.99f)
					state = 1;
				break;
			case 1:
				BGSub[1].transform.DOMove(SubLeavesMoveTarget.position, 0.25f);
				BGSub[1].transform.DOScale(1f, 0.5f);

				if(BGSub[1].transform.localScale.x >= 0.99f)
				{
					BGSub[1].transform.DOScale(1.03f, 1f).SetLoops(-1, LoopType.Yoyo);
					state = 2;
				}
				break;
			case 2:
				BGSub[2].transform.DOMove(SubGirlMoveTarget.position, 0.25f);
				BGSub[2].transform.DOScale(1f, 0.5f);

				if(BGSub[2].transform.localScale.x >= 0.99f)
				{
					BGSub[2].transform.DOScale(1.02f, 2f).SetLoops(-1, LoopType.Yoyo);
					state = 3;
				}
				break;
			case 3:
				BGSub[3].transform.DOMove(SubBoyMoveTarget.position, 0.25f);
				BGSub[3].transform.DOScale(1f, 0.5f);

				if(BGSub[3].transform.localScale.x >= 0.99f)
				{
					BGSub[3].transform.DOScale(1.02f, 2f).SetLoops(-1, LoopType.Yoyo);
					state = 4;
				}
				break;
			case 4:
				BGSub[4].transform.DOScale(1f, 0.5f);

				if(BGSub[4].transform.localScale.x >= 0.99f)
					state = 5;
				break;
			case 5:
				BGSub[5].transform.DORotate(new Vector3(0,0,360), 0.5f, RotateMode.FastBeyond360);
				BGSub[5].transform.DOScale(1f, 2f);
				BGSub[6].transform.DORotate(new Vector3(0,0,360), 0.5f, RotateMode.FastBeyond360);
				BGSub[6].transform.DOScale(1f, 2f);
				BGSub[7].transform.DORotate(new Vector3(0,0,360), 0.5f, RotateMode.FastBeyond360);
				BGSub[7].transform.DOScale(1f, 2f);

				if(BGSub[5].transform.localScale.x >= 0.99f)
					state = 6;
				break;
			case 6:
				BGSub[5].transform.DORotate(new Vector3(0,0,360), 2f, RotateMode.FastBeyond360);
				BGSub[6].transform.DORotate(new Vector3(0,0,360), 2f, RotateMode.FastBeyond360);
				BGSub[7].transform.DORotate(new Vector3(0,0,360), 2f, RotateMode.FastBeyond360);
				break;
		}*/
	}

	public void backToHome ()
	{
		SceneManager.LoadScene("Main");
	}
}
