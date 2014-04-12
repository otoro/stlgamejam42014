var dampTime : float = 0.3; //offset from the viewport center to fix damping
private var velocity = Vector3.zero;

var target : GameObject;

function FixedUpdate() {	
	
    if(target) {
        var point : Vector3 = camera.WorldToViewportPoint(target.transform.position);
        var delta : Vector3 = target.transform.position -
                    camera.ViewportToWorldPoint(Vector3(0.5, 0.5, point.z));
        var destination : Vector3 = transform.position + delta;
        transform.position = Vector3.SmoothDamp(transform.position, destination, 
                                                velocity, dampTime);
    }
}

//function Update() {
	//target = GameObject.FindGameObjectWithTag ("Player"); //find the player if this is null
//}