using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject prefab;
	Vector3 spawnPosition = new Vector3(25,0,0);
	public float spawnDelay = 2f;
	WaitForSeconds intervalWait;
	Coroutine spawn;
	bool gameOver => GameObject.Find("Player").GetComponent<PlayerController>().gameOver;
    // Start is called before the first frame update
	void Awake()
	{
		intervalWait = new WaitForSeconds(spawnDelay);
		spawn = StartCoroutine(ContinousSpawn());
        
    }

    // Update is called once per frame
    void Update()
	{
		if(gameOver)
		{
			this.OnDisable();
		}
        
    }
	IEnumerator ContinousSpawn()
	{
		while(true)
		{
			Spawn();
			yield return intervalWait;
		}
	}
	void Spawn()
	{
		Instantiate(prefab,spawnPosition, prefab.transform.rotation);
	}
	// This function is called when the behaviour becomes disabled () or inactive.
	protected void OnDisable()
	{
		StopCoroutine(spawn);
	}
}
