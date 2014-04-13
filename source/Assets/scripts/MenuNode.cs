using UnityEngine;
using System.Collections;

public class MenuNode : MonoBehaviour {
	public GameObject pointer;
	public string sceneName; // the scene to load
	public AudioClip transitionFx;
	public AudioClip mouseOverFx;

	private bool _selected;

	// Use this for initialization
	void Start () {
		//_selected = initialNode;		
        _selected = false;
		pointer.renderer.material.color = Color.blue;
	}
	
	// Update is called once per frame
	void Update () {                
        if (Input.GetMouseButtonDown(0) && _selected && sceneName != string.Empty)
        {
			audio.clip = transitionFx;
			audio.Play ();
            Application.LoadLevel(sceneName);
        }
	}


	void SetSelected() {
		_selected = true;
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
