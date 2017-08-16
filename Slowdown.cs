using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowdown : MonoBehaviour {

	GameObject player;
	GameObject gamecontrol;
	PlayerMovement playerMv;
	PowerUpsManager powerUpsManager;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		gamecontrol = GameObject.Find ("GameControl");
		playerMv = player.GetComponent<PlayerMovement> ();
		powerUpsManager = gamecontrol.GetComponent<PowerUpsManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (2, 0, 0);
		Destroy (this.gameObject, powerUpsManager.spawnTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player") {
			Destroy (this.gameObject);
			playerMv.slowdown = true;
			playerMv.slowDuration = 10f;
			Time.timeScale = 0.5f;
		}
	}
}
