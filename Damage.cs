using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

	GameObject Player;
	PlayerShooting PlayerDamage;
	GameObject GameControl;
	PowerUpsManager PowerUpsManager;
	float damageDuration;

	void Start()
	{
		Player = GameObject.FindGameObjectWithTag ("Player");
		GameControl = GameObject.Find ("GameControl");
		PlayerDamage = Player.GetComponentInChildren<PlayerShooting> ();
		PowerUpsManager = GameControl.GetComponent<PowerUpsManager> ();
	}

	// Update is called once per frame
	void Update () {
		transform.Rotate (2, 0, 0);
		Destroy (this.gameObject, PowerUpsManager.spawnTime);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.name == "Player") {
			PlayerDamage.damagePerShot += 20;
			PlayerDamage.powerUps = true; 
			PlayerDamage.damageDuration = 10f;
			Destroy(this.gameObject);
		}
	}
}