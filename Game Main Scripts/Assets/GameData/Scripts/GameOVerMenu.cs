using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
	public GameObject[] BGSub;
	
	[SerializeField]
	Transform[] moveTarget;
	int state;

	void Start()
	{
		state=0;
	}

	void Update()
	{
		switch(state) 
		{
			case 0:
				BGSub[0].transform.DOMove(moveTarget[0].position, 0.25f);
				BGSub[0].transform.DOScale(new Vector3(100,100,100), 0.25f);

				if(BGSub[0].transform.localScale.x >= 99.99f)
					state = 1;
				break;
			case 1:
				BGSub[1].transform.DOScale(new Vector3(1,1,1), 0.25f);

				if(BGSub[1].transform.localScale.x >= 0.99f)
				{
					//BGSub[1].transform.DOScale(1.03f, 1f).SetLoops(-1, LoopType.Yoyo);
					state = 2;
				}
				break;
			case 2:
				BGSub[2].transform.DOMove(moveTarget[1].position, 0.25f);
				BGSub[2].transform.DOScale(new Vector3(90,90,90), 0.25f);

				if(BGSub[2].transform.localScale.x >= 89.99f)
				{
					//BGSub[2].transform.DOScale(1.02f, 2f).SetLoops(-1, LoopType.Yoyo);
					state = 3;
				}
				break;
			case 3:
				BGSub[3].transform.DOMove(moveTarget[2].position, 0.25f);
				BGSub[3].transform.DOScale(new Vector3(90,90,90), 0.25f);

				if(BGSub[3].transform.localScale.x >= 89.99f)
				{
					state = 4;
				}
				break;
			case 4:
				BGSub[4].transform.DOScale(new Vector3(0.5f,0.5f,0.5f), 0.25f);

				if(BGSub[4].transform.localScale.x >= 0.49f)
				{
					BGSub[4].transform.DOScale(0.525f, 1f).SetLoops(-1, LoopType.Yoyo);
					state = 5;
				}
				break;
		}
	}

	public void backToHome ()
	{
		SceneManager.LoadScene("Main");
	}
}
