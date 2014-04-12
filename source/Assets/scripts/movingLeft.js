#pragma strict

function Start () {

}

function Update () {
transform.Translate(Vector3.left * Time.deltaTime);
}