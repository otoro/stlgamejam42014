using UnityEngine;
using System.Collections;

public class TextBubble : MonoBehaviour {
	public float width;
	public float height;
	public string text;
	public GameObject backgroundImage;
	public GUIStyle style;

	void OnGUI() {
		if(text != string.Empty) {
			float x = (Screen.width - width) / 2.0f;
			float y = Screen.height * 0.9f - height;
			GUI.TextArea (new Rect(x, y, width, height)
		              , text, style);

			backgroundImage.renderer.enabled = true;
		}
		else {
			backgroundImage.renderer.enabled = false;
		}

		if(backgroundImage.renderer.enabled) {
			backgroundImage.transform.position.Set(Screen.width/2.0f, Screen.height * 0.9f, 0);
		}
	}
}
