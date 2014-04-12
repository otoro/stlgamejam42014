#pragma strict

var RandomForce =  0.5;
var RandomTorque = 10;

var MinSpeed = 0.1;
var MaxSpeed = 6;

var MinTorque = -4;
var MaxTorque = 4;

InvokeRepeating("ChangeForwardForce", 1, 1);
InvokeRepeating("ChangeForwardTorque",2, 6);

function ChangeForwardForce () {
	RandomForce = Random.Range(MinSpeed, MaxSpeed);
	constantForce.relativeForce = Vector3.up * RandomForce;
}

function ChangeForwardTorque () {
	RandomTorque = Random.Range(MinTorque,MaxTorque);
	rigidbody.AddTorque (Vector3.forward * RandomTorque);
}
