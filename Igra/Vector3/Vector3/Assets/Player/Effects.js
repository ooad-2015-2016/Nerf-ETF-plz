var RootPart : Transform;
var RootPartBool = false;
var RootPartExist = false;
var Player : GameObject;

function Start () {

}

function Update () {
	if(RootPartBool && !RootPartExist)
	{
		Instantiate(RootPart, Player.transform.position, Player.transform.rotation);
		RootPartExist = true;
	}
}