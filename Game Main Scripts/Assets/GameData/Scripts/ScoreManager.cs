using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour 
{
	public static ScoreManager instance;
	public Text scoreText;
	public Text highScoreText;

	public float scoreCount;
	public float highScoreCount; 

	public float pointsPerSecond;

	public bool scoreIncreasing;

	void Awake()
	{
		instance = this;
	}

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("HighScore") != null){
			highScoreCount = PlayerPrefs.GetFloat ("HighScore");
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (scoreIncreasing) {
			scoreCount += pointsPerSecond * Time.deltaTime;	
		}
			 
		if (scoreCount > highScoreCount) {
			highScoreCount = scoreCount;
			PlayerPrefs.SetFloat ("HighScore", highScoreCount);
		}

		scoreText.text = "Score: " + Mathf.Round (scoreCount);
		highScoreText.text = "HighScore: " + Mathf.Round (highScoreCount);

	}

	//punyo kau tadi kan cak ini fir
	//nah error dio kan?
	//iyo errro
	// nah kurang ini ( samo ini ) -_-
	//setiap void ado ()
	//eh aku lah buat () tadi kak tapi didalemny ad teks wkwk
	//wkwkwk tebbalek tadi, gek kito belajar stuktur dasar lagi lah dengan noval dan irwan jugo
	//sapp


	public void backToHome (){
		SceneManager.LoadScene("Main");
	}
}
