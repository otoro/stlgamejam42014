#pragma strict

var explosion : GameObject;

function OnCollisionEnter (collision : Collision) {
	// Instantiate explosion at the impact point and rotate the explosion
	// so that the y-axis faces along the surface normal
	if (collision.gameObject.tag == "Player")
	{
	var contact : ContactPoint = collision.contacts[0];
	var rotation = Quaternion.FromToRotation(Vector3.up, contact.normal);
    Instantiate (explosion, contact.point, rotation);

	// And kill our selves
	Kill ();    
	}
}
function Kill () {
	// Stop emitting particles in any children
	var emitter : ParticleEmitter= GetComponentInChildren(ParticleEmitter);
	if (emitter)
		emitter.emit = false;

	// Detach children - We do this to detach the trail rendererer which should be set up to auto destruct
	transform.DetachChildren();
		
	// Destroy the projectile
	Destroy(gameObject);
}

@script RequireComponent (Rigidbody)