using UnityEngine;
using System.Collections;

public class EndLevelCheck : MonoBehaviour {
	public float delay;
	float timeEnded;

	bool ending = false;
	// Update is called once per frame
	void Update () {
		GameObject head = GameObject.Find ("phreakmouth");
		GameObject mouth = GameObject.Find ("phreakhead");
		GameObject player = GameObject.Find ("murcaburd");

		bool enemyAlive = !(head || mouth);
		if ( !ending && (!player || !enemyAlive )) {
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
