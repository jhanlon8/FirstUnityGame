using UnityEngine;

public class PlayerMovement : MonoBehaviour


{
    /*
	public Rigidbody rb; 

	public float forwardForce = 500f;
	public float sidewaysForce = 500f;	

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
   
        	
        	if(Input.GetKey("d"))
        	{
        		rb.AddForce(sidewaysForce * Time.deltaTime,0,0);
        	}
        	if(Input.GetKey("a"))
        	{
        		rb.AddForce(-sidewaysForce * Time.deltaTime,0,0);
        	}
       
    }
    
    */
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {   // Time.deltaTime is used for the sake of keeping things the same on all systems with different
        Vector3 force = new Vector3(0,0,350 * Time.deltaTime);
        rigidBody.AddForce(force);

        // assumes object script is attached to
        if (Input.GetKey("d"))
        {
            transform.Translate(new Vector3(.35f,0,0));
        }
        else if (Input.GetKey("a"))
        {
            transform.Translate(new Vector3(-.35f,0,0));
        }
    }

}
