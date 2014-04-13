var MagnetLayer : LayerMask;
var FieldPosition : Vector3;
var FieldRadius : float;
var FieldForce : float;

function FixedUpdate () {

    var colliders : Collider[];
    var rigidbody : Rigidbody;

    colliders=Physics.OverlapSphere (transform.position + FieldPosition, FieldRadius, MagnetLayer);

    for(var collider in colliders){

        rigidbody = collider.rigidbody;

        if(rigidbody== null )
        {
            continue;
        }
        rigidbody.AddExplosionForce (FieldForce * -1, transform.position + FieldPosition, FieldRadius);
    }
}

function OnDrawGizmosSelected()
{
    Gizmos.color= Color.red;
    Gizmos.DrawWireSphere (transform.position, FieldRadius);
}