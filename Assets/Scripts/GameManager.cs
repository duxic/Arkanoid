using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	public Ball Ball;
	public int blockCount;
	public bool gameOver;
	public TextMeshProUGUI gameOverText;
	public TextMeshProUGUI winText;
	public bool win;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		blockCount = FindObjectsOfType<Block>().Length;
	    if (Ball.below == true)
	    {
	    	gameOver = true;
	    }
	    else
	    {
	    	gameOver = false;
	    }
	    if (gameOver & !win)
	    {
	    	gameOverText.gameObject.SetActive(true);
	    }
		if (blockCount < 1)
		{
			win = true;
		}
		else
		{
			win = false;
		}
		if (!gameOver & win)
	    {
	    	winText.gameObject.SetActive(true);
	    }
    }
}
