using UnityEngine;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {
	public string sceneName; // the scene to load
	public AudioClip clickSoundFx;
	public AudioClip mouseOverFx;

	private bool _selected;
	private bool _loadScene;
	private bool _freezeControl;

	// Use this for initialization
	void Start () {			
		_loadScene = false;
		_selected = false;
		_freezeControl = false;
	}
	
	// Update is called once per frame
	void Update () {        
		if(!_freezeControl) {
			if (Input.GetMouseButtonDown(0) && _selected && sceneName != string.Empty)
			{
				if(clickSoundFx != null) {
					audio.clip = clickSoundFx;
					audio.Play ();
					_loadScene = true;
					FreezeControl ();
				}											
			}
		}

		if(!audio.isPlaying && _loadScene) {
			Application.LoadLevel(sceneName);
		}	
	}

	void FreezeControl() {
		_freezeControl = true;
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
