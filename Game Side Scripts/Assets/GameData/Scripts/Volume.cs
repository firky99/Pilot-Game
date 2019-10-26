using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour {

	[Range(0.0f, 1.0f)]
	[SerializeField]
	private float volume = 1.0f;

	// Update is called once per frame
	void Update () {
		AudioListener.volume = volume;
	}

	private static Volume instance = null;

	public static Volume Instance
	{
		get{ return instance; }
	}

	void Awake()
	{
		if(instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;
		}
		else
		{
			instance =  this;
		}
	}
}
