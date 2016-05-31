var health = 100;
var checkpointPosition : Vector3;
var SpawnPoint = GameObject;


function Start(){
  checkpointPosition=SpawnPoint.transform.position;
} 
function Update(){
  if(health<=0)
  	transform.position = checkpointPosition;
  	health = 100;

}