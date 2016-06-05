public var distance=10.0f;
public var speed = 10.0f;
var TPR=true;
var enable = false;

private var pos : Vector3;
private var tpos: Vector3;
private var cd = true;
public  var cooldown = 3;

function Update() {
	var controller : CharacterController = GetComponent(CharacterController);
	if (controller.isGrounded){
	if ( Input.GetKeyDown(KeyCode.E ) && cd ) {
		pos = transform.position;
		tpos = transform.position + ( transform.forward * distance );
		
		
		
		enable = true;
	}
	
	if ( enable ) {
		start_cd();
		transform.position += transform.forward * speed * Time.deltaTime;
	    if( transform.position == tpos) {enable=false;}
 
	}
	}
}

function start_cd() {
	cd = false;
	yield WaitForSeconds(cooldown);
	cd = true;
}

