#pragma strict

var brzina : float = 0.1;

function Update () {
 if (Input.GetKey(KeyCode.Q)){
  transform.RotateAround (Vector3.zero, Vector3.right, 90 * Time.deltaTime * brzina);}
  if (Input.GetKey(KeyCode.E)){
  transform.RotateAround (Vector3.zero, Vector3.right, -90 * Time.deltaTime * brzina);}
  if (Input.GetKey(KeyCode.Y)){
  transform.RotateAround (Vector3.zero, Vector3.forward, 90 * Time.deltaTime * brzina);}
  if (Input.GetKey(KeyCode.C)){
  transform.RotateAround (Vector3.zero, Vector3.forward, -90 * Time.deltaTime * brzina);}
  
 

}