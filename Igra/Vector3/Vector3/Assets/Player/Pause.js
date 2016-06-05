var isPaused = false;

function Update()
{
 
     if(Input.GetKeyDown("escape") && !isPaused)
   {     
      print("Paused");
      Time.timeScale = 0.0;
      var FPC = GameObject.FindWithTag("Player");
      FPC.GetComponent("CharacterMotor").enabled = false;
      FPC.GetComponent("MouseLook").enabled = false;
      Camera.mainCamera.GetComponent("MouseLook").enabled = false;
      isPaused = true;
   }
   else if(Input.GetKeyDown("escape") && isPaused)
   {
      print("Unpaused");
      Time.timeScale = 1.0;
      isPaused = false;    
      var FPC1 = GameObject.FindWithTag("Player");
      FPC1.GetComponent("CharacterMotor").enabled = true;
      FPC1.GetComponent("MouseLook").enabled = true;
      Camera.mainCamera.GetComponent("MouseLook").enabled = true;
   } 
}

function OnGUI ()
{
	if(isPaused)
   {
   		if (GUI.Button (Rect (25, 25, 100, 30), "Resume")) 
			{
			print("Unpaused");
     	    Time.timeScale = 1.0;
            isPaused = false;    
            var FPC2 = GameObject.FindWithTag("Player");
            FPC2.GetComponent("CharacterMotor").enabled = true;
            FPC2.GetComponent("MouseLook").enabled = true;
            Camera.mainCamera.GetComponent("MouseLook").enabled = true;
			}
		if (GUI.Button (Rect (25, 75, 100, 30), "Main Menu"))
			{	
			Time.timeScale = 1.0;
			Application.LoadLevel("MM");
			}
		if (GUI.Button (Rect (25, 125, 100, 30), "Quit"))
			{
			Application.Quit();
			}
   }
	
}