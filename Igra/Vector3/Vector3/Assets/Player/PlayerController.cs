using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public float normalSpeed = 4.0F;
	public float runSpeed = 2.0F;
	public float walkSpeed = 2.0F;
    public float jumpSpeed = 6.0F;
    public float gravity = 20.0F;
	
	private float y = -2.0f;
	
	private float speed;
	
    private Vector3 moveDirection = Vector3.zero;
	private bool isRunning = false;
	private bool isWalking = false;
	
	void Awake() 
	{
		speed = normalSpeed;
	    if (!networkView.isMine)
	    {
	  		GetComponentInChildren<Camera>().enabled = false;
	    }
	}
	
	void Start()
	{
		Screen.showCursor = false;
	}
	
	void Update () 
	{
		if (networkView.isMine)
	    {
			CharacterController controller = GetComponent<CharacterController>();
	        if (controller.isGrounded) 
			{
	            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
	            moveDirection = transform.TransformDirection(moveDirection);
				
				if(isRunning == true && isWalking == false) speed = normalSpeed + runSpeed;
				else if(isRunning == false && isWalking == false) speed = normalSpeed;
				
				if(isWalking == true && isRunning == false) speed = normalSpeed - walkSpeed;
				else if(isWalking == false && isRunning == false) speed = normalSpeed;
				
				moveDirection *= speed;
				
	            if (Input.GetButtonDown("Jump"))
				{
	            	moveDirection.y = jumpSpeed;
					isRunning = false;
					isWalking = false;
				}
				
				if(Input.GetButtonDown("Run"))
				{
					isRunning = true;
					isWalking = false;
				}
				else if(Input.GetButtonUp("Run"))
				{
					isRunning = false;
				}
				
				if(Input.GetButtonDown("Walk"))
				{
					isWalking = true;
					isRunning = false;
				}
				else if(Input.GetButtonUp("Walk"))
				{
					isWalking = false;
	        	}
			}
			moveDirection.y -= gravity * Time.deltaTime;
			controller.Move(moveDirection * Time.deltaTime);
		}
	}
	
	void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info) 
	{
		if (stream.isWriting) 
		{
			Vector3 pos = transform.position;
            stream.Serialize(ref pos);
        } 
		else 
		{
            Vector3 posRect = Vector3.zero;
            stream.Serialize(ref posRect);
			transform.position = posRect;
        }
	}
}
