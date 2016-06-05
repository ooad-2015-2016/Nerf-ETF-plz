var enable = true;

function Start () {
	destroy = false;
}

function Update () {

}

function OnTriggerEnter(other : Collider)
{
	if(enable && other.tag == "Player")
	{
		var script2 : RootPlacing = other.GetComponentInChildren(RootPlacing); 
		var script : move1 = other.GetComponent(move1);
		var script3 : Effects = other.GetComponent(Effects);
		script3.RootPartBool = true;
		script.speed = 0;
		script.sprintSpeed = 0;
		script.crouchSpeed = 0;
		yield WaitForSeconds(3);
		script3.RootPartExist = false;
		script3.RootPartBool = false;
		enable = false;
		script.rooted = false;
		script.speed = 10;
		script.sprintSpeed = 15;
		script.crouchSpeed = 5;
		yield WaitForSeconds(3);
		enable = true;
		script2.noRoot = true;
		Destroy(gameObject);
	}	

}