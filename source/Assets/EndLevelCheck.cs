﻿using UnityEngine;
using System.Collections;

public class EndLevelCheck : MonoBehaviour {
	public float delay;
	float timeEnded;

	bool ending = false;
	// Update is called once per frame
	void Update () {
		GameObject head = GameObject.Find ("phreakHead");
		GameObject mouth = GameObject.Find ("phreakMouth");

		if (!(head || mouth) && !ending) {
			Debug.Log ("Level Ended");
			ending = true;
			timeEnded = Time.fixedTime;
		}

		float currentDelay = Time.fixedTime - timeEnded;
		Debug.Log (currentDelay);
		if (ending && currentDelay > delay){
			Application.LoadLevel ("Hub");
		}
	}
}
