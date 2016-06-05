var diff : Vector3;
var destination : Vector3;
var current : Vector3;
var controller : CharacterController;

function Update () {
	current = transform.position;
	if(Input.GetKeyDown(KeyCode.E))
	{
	destination = transform.position + Vector3(0, 0, 0);
	diff = transform.TransformDirection(destination - current);
	controller.SimpleMove(diff);
	}
}