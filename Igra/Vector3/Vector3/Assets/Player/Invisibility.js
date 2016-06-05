public var Timer: float = 2;
var InvBuff = false;

function beInvisible() {
    renderer.enabled = false;
    yield(WaitForSeconds(Timer));
    renderer.enabled = true;
    InvBuff = false;
}


function Update() {
	if(InvBuff)
   		{Timer = 5;}
		else{Timer = 2;}
  if(Input.GetButton("Invisibility"))
    {
 beInvisible();
 
    }
}
