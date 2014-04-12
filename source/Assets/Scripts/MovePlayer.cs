using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
	public float speed = 13.5f;
	
	void Update () {
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		transform.Translate(x, y, 0);	

		Vector3 pos = transform.position;
		pos.y = Mathf.Clamp(pos.y, -5, 5);
		transform.position = pos;
	}

}
