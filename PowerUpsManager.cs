using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsManager : MonoBehaviour 
{
	public PlayerHealth playerHealth;
	public GameObject[] PowerUps;
	public float spawnTime = 15f;
	public Transform[] spawnPoints;

	void Start()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}

	void Spawn ()
	{
		if(playerHealth.currentHealth <= 0f)
		{
			return;
		}

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		Instantiate (PowerUps[Random.Range (0, PowerUps.Length)], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}