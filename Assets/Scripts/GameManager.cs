using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	public Ball Ball;
	public bool gameOver;
	public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    if (Ball.below == true)
	    {
	    	gameOver = true;
	    }
	    else
	    {
	    	gameOver = false;
	    }
	    
	    if (gameOver)
	    {
	    	gameOverText.gameObject.SetActive(true);
	    }
    }
}
