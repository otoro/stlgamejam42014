using UnityEngine;
using System.Collections;

public class SceneSwitcher : MonoBehaviour {
	public string sceneName; // the scene to load
	
	private bool _selected;
	
	// Use this for initialization
	void Start () {			
		_selected = false;
	}
	
	// Update is called once per frame
	void Update () {        
		if (Input.GetMouseButtonDown(0) && _selected && sceneName != string.Empty)
		{
			Application.LoadLevel(sceneName);
		}

		if(Input.GetMouseButtonDown (0) && _selected) {
			Debug.Log ("clicked!");
		}
	}
	
	void OnMouseOver()
	{
		Debug.Log ("mouse over");
		_selected = true;
	}
	
	void OnMouseExit()
	{
		Debug.Log ("mouse exit");
		_selected = false;
	}
}
