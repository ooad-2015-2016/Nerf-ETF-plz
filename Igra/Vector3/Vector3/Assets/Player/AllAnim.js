function Update () {
 AnimationPlay();
  
  
}
function AnimationPlay() {
if ( Input.GetKeyDown(KeyCode.W )){
 
  animation.Play("Runing");
  }
if (Input.GetKeyUp(KeyCode.W ))
   {
      animation.CrossFade("Standing"); 
   }    
   }