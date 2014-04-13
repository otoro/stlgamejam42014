using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public string prefixString;
	public int relevantDigits;
	public GUIText textField;
	public GUIText scoreBumpText;
	
	ulong scoreValue = 0;

	public void AddScore(int amount) {
		scoreValue += (uint) amount;

		GUIText scoreBumpTextObject = Instantiate (scoreBumpText, this.gameObject.guiText.transform.position, Quaternion.identity) as GUIText;
		scoreBumpTextObject.transform.parent = this.gameObject.guiText.transform;
		scoreBumpTextObject.GetComponent<ScoreBumpAnimation> ().Animate (amount);
	}

	string colorizeText (string text, string color){
		return "<color=" + color + ">" + text + "</color>";
	}

	// Update is called once per frame
	void Update () {
		string scoreValueText = scoreValue.ToString("D" + relevantDigits);
		string scoreText = colorizeText(prefixString, "white") + colorizeText(scoreValueText, "white");

		textField.text = scoreText;
	}
}
