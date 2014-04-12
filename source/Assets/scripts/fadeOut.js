#pragma strict

var fadeTexture : Texture2D;
var fadeSpeed = 0.2;
var drawDepth = -1000;

private var isFadingIn = true;
private var isFadingOut = false;
 
private var alpha = 1.0;
private var fadeDir = 1;
 
function startFade() {
    isFadingOut = true;
}

function doFade(alpha) {
    GUI.color.a = alpha;
 
    GUI.depth = drawDepth;
 
    GUI.DrawTexture(Rect(0, 0, Screen.width, Screen.height), fadeTexture);
}
 
function OnGUI() {
	if (isFadingIn) {
        alpha -= fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);
        
        doFade(alpha);
        
		if (alpha <= 0.0) {
			Debug.Log("Completed fading in");
		    isFadingIn = false;
		}
	}

    if (isFadingOut) {
        alpha += fadeDir * fadeSpeed * Time.deltaTime;
        alpha = Mathf.Clamp01(alpha);

 		doFade(alpha);
        
        if (alpha >= 1.0) {
            Debug.Log("Reloading Scene");
		    Application.LoadLevel("Credits");
		}
    }
}