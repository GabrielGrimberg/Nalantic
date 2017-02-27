using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Struct of x,y,z
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y ,0f);

		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;

		//Clmap used to make the object not go out of bounds.
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);

		this.transform.position = paddlePos;
		
	}
}
