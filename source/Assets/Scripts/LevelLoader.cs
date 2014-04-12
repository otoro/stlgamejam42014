using UnityEngine;
using System.Collections;
using System.IO;

public class LevelLoader : MonoBehaviour {
	public string level;

	void OnMouseOver () {
	    if(Input.GetMouseButtonDown(0)){
			Debug.Log("Loading " + level);

			if (level != "Exit") {
		    	Application.LoadLevel("" + level);
			} else {
				Application.Quit();
			}
	    }
    }
}