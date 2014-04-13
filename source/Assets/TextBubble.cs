using UnityEngine;
using System.Collections;

public class TextBubble : MonoBehaviour {
	public float width;
	public float height;
	public string text;
	public GUIStyle style;

	void OnGUI() {
		float x = (Screen.width - width) / 2.0f;
		float y = Screen.height * 0.9f - height;

		GUI.TextArea (new Rect(x, y, width, height)
		              , text, style);
	}
}
