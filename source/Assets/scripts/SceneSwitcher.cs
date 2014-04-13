using UnityEngine;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {
	public string sceneName; // the scene to load
	public AudioClip clickSoundFx;
	public AudioClip mouseOverFx;

	private bool _selected;
	
	// Use this for initialization
	void Start () {			
		_selected = false;
	}
	
	// Update is called once per frame
	void Update () {        
		if (Input.GetMouseButtonDown(0) && _selected && sceneName != string.Empty)
		{
			if(clickSoundFx != null) {
				audio.clip = clickSoundFx;
				audio.Play ();
			}
			Application.LoadLevel(sceneName);
		}
	}
	
	void OnMouseEnter()
	{
		audio.clip = mouseOverFx;
		audio.Play ();
		_selected = true;
	}
	
	void OnMouseExit()
	{	
		_selected = false;
	}
}
