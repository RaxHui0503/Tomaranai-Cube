
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; // a reference to the Rigidbody called "rb"

    public float forwardForce = 2000f; // variable that determines the forward force (speed)
    public float sidewaysForce = 500f; // variable that determines the sideways force (speed)

    
    void FixedUpdate() // mard this as FixedUpdate because i am using it to mess with physics 
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); //add forward force (speed)

        if (Input.GetKey("d")) // if the player is pressing "d" key
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // add force (speed) to the righe

        }
        if (Input.GetKey("a")) // if the player is pressing "a" Key
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // add force (speed) to the left

        }
        if (rb.position.y < -1f) // if the player fall to y axie -1 will restart  
        {
            FindObjectOfType<GameManger>().gameover();
        }
    }
}
