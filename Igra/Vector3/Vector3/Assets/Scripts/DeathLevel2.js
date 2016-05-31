function OnTriggerExit (other : Collider) {
	if(other.tag == "Player")
		Application.LoadLevel("Level2");

}