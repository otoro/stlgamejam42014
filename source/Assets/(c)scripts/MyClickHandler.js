var CamToMove : GameObject;
var speech2 : GameObject;

CamToMove = Camera.main.gameObject;

function OnLeftClick()
{
	Debug.Log("OnLeftClick triggered on "+gameObject.name+"!");

	if (gameObject.name == "start") { 
		//start()
	}
}

function OnRightClick()
{
	Debug.Log("OnRightClick triggered on "+gameObject.name+"!");
}
