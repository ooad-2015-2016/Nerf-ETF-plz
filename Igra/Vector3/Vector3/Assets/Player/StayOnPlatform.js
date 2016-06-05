var myCharacterController : CharacterController;

private var activePlatform : Transform;

private var hit : ControllerColliderHit;

private var activeGlobalPlatformPoint : Vector3;

private var activeLocalPlatformPoint : Vector3;

private var activeGlobalPlatformRotation : Quaternion;

private var activeLocalPlatformRotation : Quaternion;

var tagName : String;

private var moveDirection = Vector3.zero;

private var grounded : boolean = false;

function FixedUpdate () {

    if (tagName != "elevator") 

    {

        activePlatform = null;

        lastPlatformVelocity = Vector3.zero;

    }

    if (tagName == "elevator") 

        {

        if (grounded) {

            // We are grounded on a Moving Surface, so recalculate move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

            moveDirection = transform.TransformDirection(moveDirection);// Move the controller

            var controller : CharacterController = GetComponent(CharacterController);

            var flags = controller.Move(moveDirection * Time.deltaTime);

            grounded = (flags & CollisionFlags.CollidedBelow) != 0;

            //Keep moving (?) by getting the spped var from the FPSWalker CC script or whatever you are using 

            //moveDirection *= FPSWalker.speed;

            

        }

    var calculatedMovement = moveDirection * Time.deltaTime;

        // Moving platform support

        if (activePlatform != null) {

            var newGlobalPlatformPoint = activePlatform.TransformPoint(activeLocalPlatformPoint);

            var moveDistance = (newGlobalPlatformPoint - activeGlobalPlatformPoint);

            transform.position = transform.position + moveDistance;

            lastPlatformVelocity = (newGlobalPlatformPoint - activeGlobalPlatformPoint) / Time.deltaTime;

            // If you want to support moving platform rotation as well:

            var newGlobalPlatformRotation = activePlatform.rotation * activeLocalPlatformRotation;

            var rotationDiff = newGlobalPlatformRotation * Quaternion.Inverse(activeGlobalPlatformRotation);

            transform.rotation = rotationDiff * transform.rotation;

            }

            else

            {

                lastPlatformVelocity = Vector3.zero;

            }

            //Controller Move  takes place here 

            collisionFlags = myCharacterController.Move (calculatedMovement);

            // Moving platforms support

        if (activePlatform != null) {

            activeGlobalPlatformPoint = transform.position;

            activeLocalPlatformPoint = activePlatform.InverseTransformPoint (transform.position);

            // If you want to support moving platform rotation as well:

            activeGlobalPlatformRotation = transform.rotation;

            activeLocalPlatformRotation = Quaternion.Inverse(activePlatform.rotation) * transform.rotation;

            }

    }

}

 

function OnControllerColliderHit (hit : ControllerColliderHit) {

    // Make sure we are really standing on a straight platform

    // Not on the underside of one and not falling down from it either!

    if (hit.moveDirection.y < -0.9 && hit.normal.y > 0.5) {

        activePlatform = hit.collider.transform;

        tagName = hit.collider.tag;

    }

}