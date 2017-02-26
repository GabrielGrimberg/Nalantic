using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour 
{
	//No multiple music playing.
	static MusicPlayer instance = null;

	void Awake()
	{
		if(instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			//Takes a GameObject instance and doesn't destroy on load.
			GameObject.DontDestroyOnLoad(gameObject);
		}

	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
