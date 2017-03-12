using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour 
{
	public Sprite[] hitSprites;
	private int timesHit;
	private LevelManager levelManager;
	public static int breakableBrick = 0;
	private bool isBreakable;

	// Use this for initialization
	void Start() 
	{
		isBreakable = (this.tag == "Breakable");

		//Keep track of breakable bricks.
		if(isBreakable)
		{
			breakableBrick++;
		}

		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager>();

	}
	
	// Update is called once per frame
	void Update() 
	{
		
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if(isBreakable)
		{
			HitsHandle();
		}
	}

	void HitsHandle()
	{
		print("Hit");
		timesHit++;

		int maxHits = hitSprites.Length + 1;
		if(timesHit >= maxHits)
		{
			breakableBrick--;
			levelManager.BrickDestroy(); //Checks if last brick is destoryed.
			Destroy(gameObject);
		}
		else
		{
			LoadSprites();

		}

	}

	void LoadSprites()
	{
		int spriteIndex = timesHit - 1;

		if(hitSprites[spriteIndex])
		{
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
		}

	}

	//TODO Remove this method once we can actually win.
	void SimulateWin()
	{
		levelManager.LoadNextLevel();

	}

}
