var speed : float = 100.0;
var cooldown = false;
var cdtime : float = 0.0;
var timer : float = 0.0;

function FixedUpdate () {
	if(Input.GetKey(KeyCode.E) && cooldown == false)
		{
		for(timer = 0.0; timer!=5; timer += Time.deltaTime)
			{
				
			}
		if(timer >= 5)
			{
				cooldown = true;
			}
		}
	
	if(cdtime !=5 && cooldown)
	{
		cdtime += Time.deltaTime;
		if(cdtime >=5)
		{
			cooldown = false;
			timer = 0.0;
		}
	}		
}