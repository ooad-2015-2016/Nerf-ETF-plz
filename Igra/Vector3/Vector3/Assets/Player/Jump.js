var speed : float = 6.0;
var jumpSpeed : float = 8.0;
var gravity : float = 20.0;
var en = true;

private var moveDirection : Vector3 = Vector3.zero;

function Update() {
    var controller : CharacterController = GetComponent(CharacterController);
    if (controller.isGrounded) {
     //   if (Input.GetButton ("Jump")) {
     //       moveDirection.y = jumpSpeed;
     //   }
  //  }

   moveDirection.y -= gravity * Time.deltaTime/2;
    
    controller.Move(moveDirection * Time.deltaTime);

}  
}