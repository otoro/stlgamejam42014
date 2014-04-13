#pragma strict
var speed: float = 1;

function Start () {

}

function Update () {
transform.Translate(Vector3.left * (Time.deltaTime * speed));
}