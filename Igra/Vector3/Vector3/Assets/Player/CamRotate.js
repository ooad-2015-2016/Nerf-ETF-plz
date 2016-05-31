#pragma strict
// This script goes on your camera
public var rollSpeed:float;
function Start () {
}
function Update () {
 transform.Rotate(Vector3.right, 10.0f * Time.deltaTime, Space.World);
}
