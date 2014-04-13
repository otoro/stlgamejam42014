using UnityEngine;
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

	public float health;

	public DamageReceiver healthScript; //get the health script
	public GameObject player;


	// Use this for initialization
	void Start () {
		health = 70.0f;
		healthScript = player.GetComponent<DamageReceiver>();
	}
	
	// Update is called once per frame
	void Update () {	
		health = healthScript.hitPoints;
		try {
			SpriteRenderer sr = healthSprite.GetComponent<SpriteRenderer>();
			if(health > 60.0f) {
				sr.sprite = health0;

			}
			else if (health > 500.0f) {
				sr.sprite = health1;
			}
			else if(health > 400.0f) {
				sr.sprite = health2;
			}
			else if(health > 300.0f) {
				sr.sprite = health3;
			}
			else if (health > 200.0f) {
				sr.sprite = health4;
			}
			else if (health > 100.0f) {
				sr.sprite = health5;
			}
			else if(health > 0.0f) {
				sr.sprite = health6;
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
