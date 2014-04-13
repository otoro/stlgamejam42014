using UnityEngine;
using System.Collections;

public class MenuNode : MonoBehaviour {
	public GameObject pointer;
	public string sceneName; // the scene to load
	public AudioClip transitionFx;
	public AudioClip mouseOverFx;

	private bool _selected;
	private bool _loadScene;
	private bool _freezeControl;

	// Use this for initialization
	void Start () {			
        _selected = false;
		_loadScene = false;
		_freezeControl = false;
		pointer.renderer.material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {          
		if(!_freezeControl) {
	        if (Input.GetMouseButtonDown(0) && _selected && sceneName != string.Empty)
	        {
				if(transitionFx != null) {		
					audio.clip = transitionFx;
					audio.Play ();
				}

				FreezeControl();
				_loadScene = true;
	        }
		}

		if(!audio.isPlaying && _loadScene) {
			try {
				Application.LoadLevel(sceneName);
			}
			catch(UnityException e) {
				Debug.LogException(e);
			}
		}
	}

	void FreezeControl() {
		_freezeControl = true;
	}

    void OnMouseEnter()
    {
		audio.clip = mouseOverFx;
		audio.Play ();
		pointer.renderer.material.color = Color.red;
        _selected = true;
    }

    void OnMouseExit()
    {
		pointer.renderer.material.color = Color.blue;
        _selected = false;
    }
}
