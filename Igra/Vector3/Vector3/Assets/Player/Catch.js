 function Start()
{
	transform.renderer.enabled = false;
}
 
function OnTriggerEnter(other : Collider)
{
	if(other.tag == "Enemy")
	{
	//	var script : Wall1 = GameObject.Find("Room1").GetComponent(Wall1);
	//	script.enemiesLeft -= 1;
		Destroy(other.gameObject);
	}
}
