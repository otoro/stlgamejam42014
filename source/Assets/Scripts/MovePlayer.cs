using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour {
	private float speed;
	
	void Start () {
		speed = 13.5f;
	}
	
	void Update () {
		float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
		float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
		
		transform.Translate(x, y, 0);	
	}
}
