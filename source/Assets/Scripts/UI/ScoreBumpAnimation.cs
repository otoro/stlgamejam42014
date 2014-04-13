using UnityEngine;
using System.Collections;

public class ScoreBumpAnimation : MonoBehaviour {
	public GUIText sourceText;
	public GUIText targetText;
	public float speed;
	public int fontDownsize;

	string prefixString = "";
	double startTime;
	GUIText self;
	bool isAnimating = false;

	enum GameColors {
		BLUE, RED, WHITE
	}

	public void Animate(int amount) {
		self = this.gameObject.guiText;

		self.font = sourceText.font;
		self.fontSize = sourceText.fontSize - fontDownsize;
		self.fontStyle = sourceText.fontStyle;

		System.Array values = System.Enum.GetValues(typeof(GameColors));
		GameColors randomColor = (GameColors)values.GetValue(Random.Range(0, values.Length));

		self.text = "<i><color=" + randomColor + ">+" + amount + "</color></i>";
		
		startTime = Time.time;

		isAnimating = true;
	}

	void Start() {
	}

	// Update is called once per frame
	void Update () {
		if (isAnimating) {
			float alpha = Mathf.Lerp (1f, 0f, (float)(Time.time - startTime));
			Color newColor = new Color (self.material.color.r, self.material.color.g, self.material.color.b, alpha);
			self.material.color = newColor;

			transform.Translate (Vector3.up * speed * Time.deltaTime);

			if (alpha <= 0) {
				Destroy(this.gameObject);
			}
		}
	}
}
