using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//Takes a GameObject instance and doesn't destroy on load.
		GameObject.DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
