using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   
    public Rigidbody rb;
    public float forwardForce;
    public float sidewayForce;
    public float upForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKeyUp("d"))
        {
            rb.AddForce(-sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKeyUp("a"))
        {
            rb.AddForce(sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
       
    ///if (Input.GetKey("space"))
        {
            ///rb.AddForce(0,upForce*Time.deltaTime,0);
        }

}
}

