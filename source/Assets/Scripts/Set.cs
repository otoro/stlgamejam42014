using UnityEngine;
using System.Collections;

public class Set : MonoBehaviour {

	public float hSliderValue = 0.0f;

	/*
	public float minValue = 0;
	public float maxValue = 1;
	public float currentValue = 0;

	private bool connectedToMouse = false;
	private float originalX = AudioListener;
	private float originalMouseX = 0;
	private float currentX = 0;
	*/
	void OnGUI () 
	{
		AudioListener.volume = 1.0f;

		// Group set up

		GUI.BeginGroup (new Rect (Screen.width / 2 + 150, Screen.height / 2 + 50, 500, 250));
		
		// Boxes!!!

		GUI.Box (new Rect (6,0,150,150), "OPTIONS");
		GUI.Label (new Rect (10,20,100,30), "Game Volume: ");
		hSliderValue = GUI.HorizontalSlider (new Rect (10, 45, 100, 50), hSliderValue, 0.0f, 1.0f);

		GUI.Label (new Rect (10, 60, 100, 60), " This may or may not be fully configurated!!!");

		// Ending group

		GUI.EndGroup ();
	}

/*
	void OnMouseDown () 
	{
		
		connectedToMouse = true;
		
		originalMouseX = Input.mousePosition.x;
		
		originalX = hSliderValue;


	if(hSliderValue = 0)
	{
			currentX = AudioSource.ignoreListenerVolume;
	}

	}

	void OnMouseUp () 
	{
		
		connectedToMouse = false;
		
	}

	void Update () {
		
		if (connectedToMouse == true) {
		
			currentX = originalX - (originalMouseX - Input.mousePosition.x);
			
			currentValue = (((currentX - hSliderValue / (hSliderValue - hSliderValue)) * (maxValue - minValue)) + minValue);
			
		}
		
		if (currentValue < minValue) 
		{
			
			currentValue = minValue;
			
		} else if (currentValue > maxValue) 
		{
			
			currentValue = maxValue;
			
		}
		
		AudioListener.volume = currentValue;

	}
	
*/
}
