using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
	public Camera gameCamera;
	public float speed = 13.5f;
	
	void Update () {
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;

		transform.Translate(x, y, 0);	
		;
		Vector3 pos = transform.position;
		pos.y = Mathf.Clamp(pos.y, (gameCamera.transform.position.y-4.6f), (gameCamera.transform.position.y+4.6f));
		pos.x = Mathf.Clamp(pos.x, (gameCamera.transform.position.x-8.5f), (gameCamera.transform.position.x+8.5f));
		transform.position = pos;
	}

}
