using UnityEngine;
using System.Collections;
using System.IO;

public class CreditScroller : MonoBehaviour {
	public SpriteRenderer background;
	public int fadeLength;
	public GUIText credits;
	public string titleSize;

	void Start () {
		credits.richText = true;
		string creditsText = Resources.Load<TextAsset> ("Credits.txt").text;
		creditsText = creditsText.Replace ("%TITLE_SIZE%", "" + titleSize);

		credits.text = creditsText;
	}

	void FixedUpdate () {
		Camera mainCamera = Camera.main;
		GameObject.Find("CreditsText").transform.Translate(Vector3.up * Time.deltaTime / 10);
		mainCamera.transform.Translate(Vector3.down * Time.deltaTime);

		if (mainCamera.transform.localPosition.y - mainCamera.orthographicSize - fadeLength < background.transform.localPosition.y - background.bounds.extents.y) {
			Debug.Log ("Starting fade");
			SendMessage("startFade");
		}
	}
	
    void OnGUI() {
        Event e = Event.current;
		if (e.button == 0 && e.isMouse && Input.GetMouseButtonDown(0))
			Application.LoadLevel ("Title");
	}
}