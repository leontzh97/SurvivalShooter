using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recover : MonoBehaviour {

	GameObject Player;
	PlayerHealth PlayerHealth;
	GameObject GameControl;
	PowerUpsManager PowerUpsManager;

	void Start()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		GameControl = GameObject.Find ("GameControl");
		PlayerHealth = Player.GetComponent<PlayerHealth> ();
		PowerUpsManager = GameControl.GetComponent<PowerUpsManager> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 2, 0);
		Destroy (this.gameObject, PowerUpsManager.spawnTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player") {
			if (PlayerHealth.currentHealth < PlayerHealth.startingHealth) {
				PlayerHealth.currentHealth += 10;
				PlayerHealth.healthSlider.value = PlayerHealth.currentHealth;
				Destroy (this.gameObject);
			}

		}
	}
}
