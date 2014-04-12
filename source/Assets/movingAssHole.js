#pragma strict

function Start () {

}

function Update () {
var sine=Mathf.Sin(Time.deltaTime);
transform.Translate(Vector3.down*sine);
}