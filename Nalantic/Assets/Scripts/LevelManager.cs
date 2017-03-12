using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour 
{

	public void LoadLevel(string name)
	{
		Application.LoadLevel(name);

	}

	public void QuitRequest()
	{
		Debug.Log("Quit Is Pressed");
		Application.Quit();
	}
		
	public void LoadNextLevel()
	{
		SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void BrickDestroy()
	{
		if(Brick.breakableBrick <= 0)
		{
			LoadNextLevel();
		}

	}
		

}
