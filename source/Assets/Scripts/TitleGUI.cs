using UnityEngine;
using System.Collections;

public class TitleGUI : MonoBehaviour 
{
	
	void OnGUI ()
	{
	
		AudioListener.volume = 1F;

		
		if (GUI.Button (new Rect (50, 10, 100, 100), "Settings")) 
		{
			print ("this is the volume settings, the curent level is  " + AudioListener.volume);
		}

		
	}

	

}
