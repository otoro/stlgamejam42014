using UnityEngine;
using System.Collections;

public class directionalFire : MonoBehaviour {
	public GameObject relativePoint;
	public Texture2D bulletTexture;
	public int fireRate; // number of frames between each shot

	private int _shotPauseTime;
	// Use this for initialization
	void Start () {	
		_shotPauseTime = fireRate;
	}
	
	// Update is called once per frame
	void Update () {
		if(_shotPauseTime == 0) {		
			Sprite bullet = Sprite.Create (bulletTexture,
			                               new Rect(this.transform.position.x, this.transform.position.y,
			         								bulletTexture.width, bulletTexture.height),
			                               new Vector2(bulletTexture.width / 2.0f, bulletTexture.height / 2.0f));
		
			Quaternion q = new Quaternion();
			q.SetFromToRotation(this.transform.position, relativePoint.transform.position);
			Instantiate(bullet, this.transform.position, q);
			Debug.Log ("bullet created");
			_shotPauseTime = fireRate;
		}
		else {
			_shotPauseTime--;
		}
	}
}
