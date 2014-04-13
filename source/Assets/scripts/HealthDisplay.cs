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

	private float health;

	// Use this for initialization
	void Start () {
		health = 70.0f;
	}
	
	// Update is called once per frame
	void Update () {	
		try {
			SpriteRenderer sr = healthSprite.GetComponent<SpriteRenderer>();
			if(health > 60.0f) {
				sr.sprite = health0;

			}
			else if (health > 50.0f) {
				sr.sprite = health1;
			}
			else if(health > 40.0f) {
				sr.sprite = health2;
			}
			else if(health > 30.0f) {
				sr.sprite = health3;
			}
			else if (health > 20.0f) {
				sr.sprite = health4;
			}
			else if (health > 10.0f) {
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
