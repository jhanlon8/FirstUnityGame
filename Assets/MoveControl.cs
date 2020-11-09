using UnityEngine;

public class MoveControl : MonoBehaviour
{
   
    public PlayerMovement pm;  // PlayerMovement is a script

    // Start is called before the first frame update
    void Start()
    { 
        pm = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        
        if (Input.GetKey("s"))
        {
            pm.enabled = false;
            Debug.Log("pressed s");
        } 
        else if (Input.GetKey("w"))
        {
            pm.enabled = true;
            Debug.Log("pressed w");
        }
    }

}
