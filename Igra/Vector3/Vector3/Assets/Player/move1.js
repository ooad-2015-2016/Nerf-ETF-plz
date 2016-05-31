var speed : float = 10.0;
var lookSpeed : float = 10.0;
var moveSpeed : float = 10.0;
var crouchSpeed : float = 5;
var sprintSpeed : float = 15;
var jumpSpeed : float;
var normalJump : float = 8.0;
var megaJump : float = 24.0;
var gravity : float = 20.0;
var cdtime : float = 0.0;
var jumptime : float = 3.0;
var time : float = 0.0;
var cd = false;
var sprintEnable = true;
public var cameraController : Camera;
var spBuff = false;
var rooted = false;
var JmpBuff = false;
var megaJmp = false;
var rootEnable = false;

private var moveDirection : Vector3 = Vector3.zero;

function Start()
{
	jumpSpeed = normalJump;
}


function Update() {
	if(!megaJmp)
	{jumpSpeed = normalJump;}
   if(Input.GetKeyDown(KeyCode.E))
   {BuffJump();}
    var controller : CharacterController = GetComponent(CharacterController);
    if (Input.GetKeyDown(KeyCode.Q) && time < jumptime && cd==false)
        {
        	

              jumpSpeed = megaJump;
              megaJmp = true;	

        	
        }
    if(megaJmp)
    {
    	time += Time.deltaTime;
    	if(time >= jumptime)
    	{
    		cd = true;
    		megaJmp = false;	
    	}
    }
	if(cdtime != 5 && cd)
    			{
   				cdtime += Time.deltaTime;}
    	    			if(cdtime >= 5 && cd)
    				{
    					cd = false;
    					time = 0;  
    					cdtime = 0.0;					   					
    				}


    			
    
    if (Input.GetButton("Left"))
  	{transform.Rotate(Vector3.down *10* lookSpeed * Time.deltaTime);
  	   }
      if (Input.GetButton("Right"))
	{transform.Rotate(Vector3.up *10* lookSpeed * Time.deltaTime);
	   }
	 if (controller.isGrounded) { 
    	rootEnable = true;}
    	else{rootEnable = false;} 
    if (controller.isGrounded) {  
    	if(Input.GetKey(KeyCode.R))
    	{
    		BuffSprint();
    	}   
 		if(Input.GetKey(KeyCode.LeftShift) && sprintEnable)
 			{moveSpeed = sprintSpeed;}
 		else
 		{
 			if(Input.GetKey(KeyCode.LeftControl))
 			{moveSpeed = crouchSpeed; sprintEnable = false;}
 			else
 			{moveSpeed = speed; sprintEnable = true;}
 		}
       moveDirection = Vector3(0, 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed;				
       if (Input.GetButtonDown ("Jump")) {
            moveDirection.y = jumpSpeed;
       }			     
}
                   


    moveDirection.y -= gravity * Time.deltaTime/2;  
  
    controller.Move(moveDirection * Time.deltaTime);}
    
function BuffSprint()
{
	if(spBuff && !rooted)
	{
		sprintSpeed = 25;
		yield(WaitForSeconds(5));
		sprintSpeed = 15;
		spBuff = false;
	}	
}

function BuffJump()
{
	if(JmpBuff)
   {
   	    normalJump = 10;
  	 	megaJump = 18;
  	 	yield(WaitForSeconds(5));
  	 	normalJump = 5;
  	 	megaJump = 9;
	}
   	
}










