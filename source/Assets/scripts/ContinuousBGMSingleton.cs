using UnityEngine;
using System.Collections;

public class ContinuousBGMSingleton : MonoBehaviour {
	public AudioClip menuClip;
	public AudioClip levelClip;
	public AudioClip creditsClip;

	private static ContinuousBGMSingleton instance = null;
	private string _loadedLevelName; // stores previously loaded level
	private bool menuClipPlaying;

	public static ContinuousBGMSingleton Instance {
		get { return instance; }
	}
	
	void Awake() {
		if(instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		}
		else {
			instance = this;
		}
		
		DontDestroyOnLoad(this.gameObject);
	}
	
	// Use this for initialization
	void Start () {
		_loadedLevelName = Application.loadedLevelName;
		if(_loadedLevelName == "Title" || _loadedLevelName == "Settings" || _loadedLevelName == "Hub")
			menuClipPlaying = true;
		else
			menuClipPlaying = false;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// check if we've changed levels
		if(_loadedLevelName != Application.loadedLevelName) {
			// check if the music needs to be switched
			if(_loadedLevelName != "Level" &&
		        Application.loadedLevelName == "Level") {

				audio.clip = levelClip;
				audio.Play ();
				_loadedLevelName = Application.loadedLevelName;
				menuClipPlaying = false;
			}
			else if(_loadedLevelName != "Credits" && 
			        Application.loadedLevelName == "Credits") {				

				audio.clip = creditsClip;
				audio.Play ();			
				_loadedLevelName = Application.loadedLevelName;
				menuClipPlaying = false;
			}
			else if(!menuClipPlaying) {
				audio.clip = menuClip;
				audio.Play ();
				_loadedLevelName = Application.loadedLevelName;
				menuClipPlaying = true;
			}
		}
	}
}
