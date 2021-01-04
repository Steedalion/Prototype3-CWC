using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
	            float moveSpeed;
	public float leftBound = -15f;
	public LevelInfo level; 
	bool gameOver => GameObject.Find("Player").GetComponent<PlayerController>().gameOver;
	bool isObstacle;
    // Start is called before the first frame update
    void Start()
	{
		if(level!=null){moveSpeed = level.moveSpeed;}
		isObstacle = gameObject.CompareTag("Obstacle");
	    //gameOver => GameObject.Find("Player").GetComponent<PlayerController>().gameOver;
    }

    // Update is called once per frame
    void Update()
	{
		if(!gameOver){
	    transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
		}
		if(isObstacle && transform.position.x < leftBound)
		{
			Destroy(gameObject);
		}
	}
	
}
