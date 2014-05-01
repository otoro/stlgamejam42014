var projectile : Rigidbody;
var initialSpeed = 20.0;
var reloadTime = 0.5;

var currentAmmoCount = 20;
var magChangeTime = 3.0;

var InitialAmmo = 45;

var nozzle : Transform;

var shootSound : AudioClip;

var strayFactor : float;

private var lastShot = -10.0;

function FixedUpdate () {
	// Did the user press fire?
	if (Input.GetButton ("Fire1"))
		Fire();
}

function Fire () {
	// Did the time exceed the reload time?
	if (Time.time > reloadTime + lastShot && currentAmmoCount > 0) {
		// Play a shooting audio clip
		if (shootSound)
			AudioSource.PlayClipAtPoint(shootSound, transform.position);
	
		// create a new projectile, use the same position and rotation as the Launcher.
		var instantiatedProjectile : Rigidbody = Instantiate (projectile, nozzle.position, nozzle.rotation);
		
		var randomNumberX = Random.Range(-strayFactor, strayFactor);
        var randomNumberY = Random.Range(-strayFactor, strayFactor);
        var randomNumberZ = Random.Range(-strayFactor, strayFactor);
		

		instantiatedProjectile.transform.Rotate(randomNumberX, randomNumberY, randomNumberZ);
		
		// Give it an initial forward velocity. The direction is along the z-axis of the missile launcher's transform.
		instantiatedProjectile.rigidbody.AddForce(instantiatedProjectile.transform.right * initialSpeed * 50);

		// Ignore collisions between the missile and the character controller
		//Physics.IgnoreCollision(instantiatedProjectile.collider, transform.root.collider);
		
		lastShot = Time.time;
		currentAmmoCount--;
		//animation.Play("FireOneShot");
		//yield WaitForSeconds (animation.clip.length);
			//animation.Play("Idle");
	}
	if (currentAmmoCount <= 0) {
		yield WaitForSeconds(magChangeTime);
		currentAmmoCount = InitialAmmo;
	}
}
