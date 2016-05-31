var enable = true;

function Update (){
if(!Input.GetKey(KeyCode.LeftShift))
{
	if (Input.GetKeyDown(KeyCode.LeftControl) && enable){ 
 	   transform.position.y -= 1.5;
	    transform.localScale.y = 0.25;
	    enable=false;
	}
	if (Input.GetKeyUp(KeyCode.LeftControl) && !enable){ 
  	  transform.position.y += 1.5;
  	  transform.localScale.y = 1.0;
  	  enable=true;
	}
}
} 