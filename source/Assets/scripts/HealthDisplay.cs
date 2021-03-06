﻿using UnityEngine;
using System.Collections;

public class HealthDisplay : MonoBehaviour {
	public GameObject healthSprite;
	public Sprite health0;
	public Sprite health1;
	public Sprite health2;
	public Sprite health3;
	public Sprite health4;
	public Sprite health5;
	public Sprite health6;

	private float health;

	public DamageReceiver healthScript; //get the health script
	public GameObject player;
	private float _maxHealth;

	// Use this for initialization
	void Start () {
		health = healthScript.hitPoints;
		_maxHealth = health;
		healthScript = player.GetComponent<DamageReceiver>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {	
		health = healthScript.hitPoints;
		try {
			SpriteRenderer sr = healthSprite.GetComponent<SpriteRenderer>();
			float percent = health / _maxHealth;
			Debug.Log (percent);
			if(percent == 1.0f) {
				sr.sprite = health0;

			}
			else if (percent == 0.875f) {
				sr.sprite = health1;
			}
			else if(percent == 0.75f) {
				sr.sprite = health2;
			}
			else if(percent == 0.625f) {
				sr.sprite = health3;
			}
			else if (percent == 0.5f) {
				sr.sprite = health4;
			}
			else if (percent == 0.375f) {
				sr.sprite = health5;
			}
			else if(percent == 0.25f) {
				sr.sprite = health6;
			}
			else {
				sr.sprite = null;
			}

		}
		catch (UnityException e) {
			Debug.LogException(e);
		}
	}

	float getHealth() {
		return health;
	}

	void decHealth(float amount) {
		health -= amount;
	}
}
