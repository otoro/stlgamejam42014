using UnityEngine;
using System.Collections;

public class rocket : MonoBehaviour {
	public Rigidbody rocketClass;
	private bool mouseDown;
	public bool canrocket = true;
	
	void Update() {
		
		Vector3 position = new Vector3 (transform.position.x,transform.position.y,transform.position.z);


		if (canrocket){
		if (Input.GetMouseButtonDown(1) && !mouseDown){
			mouseDown = true;
			Debug.Log("Creating rocket");

			Vector3	position1 = new Vector3(position.x,position.y+0.8f,0);
			Vector3 position2 = new Vector3(position.x,position.y-0.8f,0);
			
				Instantiate(rocketClass, position1, transform.rotation); 
				Instantiate(rocketClass, position2, transform.rotation); 
		}
		
		if (Input.GetMouseButtonUp(1) && mouseDown) {
			mouseDown = false;
		}
		}
	}
}
