var Trap : Transform;
var noRoot = true;
 
function Update ()
{
    if(Input.GetKeyDown(KeyCode.KeypadEnter) && noRoot)
    {
    Instantiate(Trap,transform.position,Quaternion.identity);
    noRoot = false;
     }
}